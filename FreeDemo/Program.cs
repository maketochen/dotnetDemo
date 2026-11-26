using FreeDemo;
using FreeSql;
using System.Buffers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Channels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;


#region freesql
//  var fsql = new FreeSqlBuilder()
//      .UseConnectionString(DataType.PostgreSQL, "Host=127.0.0.1;Port=5432;Database=devdb;Username=devuser;Password=devpass;")
//      .UseAutoSyncStructure(true) //自动同步实体结构到数据库
//       .UseMonitorCommand(cmd =>
//       {
//           Console.WriteLine("📌 SQL：" + cmd.CommandText);
//       })
//      .Build();

//  fsql.CodeFirst.SyncStructure<User>();


//  // 插入数据
//  var user = new User { Name = "Alice", Age = 30 };
//  fsql.Insert(user).ExecuteAffrows();

//  // 查询数据

//  var users = fsql.Select<User>().ToList();
//  users.ForEach(u => Console.WriteLine(u.Name));

//  // 更新数据
//  user.Age = 31;
//  fsql.Update<User>().SetSource(user).ExecuteAffrows();
//  Console.WriteLine(user.Age);


//var affectedRows = fsql.Delete<User>().Where(u => u.Id == 1).ExecuteAffrows();
//  Console.WriteLine(affectedRows); 
#endregion

#region ReadOnlySpan-ArrayPool

//Console.WriteLine("===== .NET 8 高性能处理演示 =====");

//// 初始化模拟的日志工具和处理器
//var logger = new SimpleLogger();
//var processor = new DeviceDataProcessor(logger); // 使用主构造函数注入

//// --- 场景 A：解析小报文 (利用 Span 和 Source Generator) ---
//var json = "{\"DeviceId\":1001, \"Value\":23.5, \"Status\":\"OK\", \"Timestamp\":1718888888}";
//byte[] rawBytes = Encoding.UTF8.GetBytes(json);

//Console.WriteLine("\n[执行解析...] ");
//processor.ProcessRawData(rawBytes);


//// --- 场景 B：处理超大报文 (利用 ArrayPool 避开 LOH) ---
//Console.WriteLine("\n[处理大对象...] ");
//processor.HandleHugePayload(90000); // 90,000 字节 > 85,000 字节，原本会进 LOH

//Console.WriteLine("\n===== 程序执行完毕 =====");
//Console.ReadLine(); // 防止窗口直接关闭


//// ==========================================================
//// 2. 数据模型与 Source Generator (源生成器)
//// ==========================================================

//// 使用 record 简洁定义模型
//public record DevicePayload(int DeviceId, double Value, string Status, long Timestamp);

//// [关键点]：告诉编译器在编译时生成序列化代码，避开运行时反射
//[JsonSerializable(typeof(DevicePayload))]
//internal partial class DeviceJsonContext : JsonSerializerContext { }


//// ==========================================================
//// 3. 业务处理器 - 展示 .NET 8 核心语法
//// ==========================================================

//// [Primary Constructor]：类名后直接跟括号，相当于定义了构造函数并注入了 logger
//public class DeviceDataProcessor(SimpleLogger logger)
//{
//    public void ProcessRawData(ReadOnlySpan<byte> dataSpan)
//    {

//       // dataSpan[0] = (byte)'{'; // 模拟修改数据，展示 Span 的可变性


//        // 直接在 Span 上反序列化，无需转 string，零分配内存
//        var payload = JsonSerializer.Deserialize(
//            dataSpan,
//            DeviceJsonContext.Default.DevicePayload);


//        if (payload != null)
//        {
//            logger.Log($"解析成功: 设备ID={payload.DeviceId}, 数值={payload.Value}");
//        }
//    }

//    public void HandleHugePayload(int size)
//    {
//        // [ArrayPool]：从内存池租借，而不是在堆上 new
//        // 这样即便数组很大，也不会因为频繁创建导致 Gen 2 GC 压力
//        byte[] buffer = ArrayPool<byte>.Shared.Rent(size);

//        try
//        {
//            // 模拟填充数据
//            Array.Fill(buffer, (byte)1, 0, 100);
//            logger.Log($"成功租借 {size} 字节内存，避开了直接在 LOH 上分配空间。");
//        }
//        finally
//        {
//            // 必须归还，否则会导致内存泄漏
//            ArrayPool<byte>.Shared.Return(buffer);
//            logger.Log("内存已归还至池中。");
//        }
//    }
//}

//// 一个简单的日志模拟器
//public class SimpleLogger
//{
//    public void Log(string message) => Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {message}");
//} 
#endregion

#region Channel
//Console.WriteLine("===== .NET 8 Channel 高性能队列演示 =====");

//// 1. 创建一个有限容量的通道（最多堆积 5 条数据）
//// 这种“背压”机制能防止内存被无限撑爆
//var channel = Channel.CreateBounded<string>(new BoundedChannelOptions(5)
//{
//    FullMode = BoundedChannelFullMode.Wait // 如果满了，生产者就等一会儿
//});

//// 2. 启动消费者（后台处理任务）
//// 这里的变量注入依然可以用 .NET 8 的思维
//var consumerTask = Task.Run(async () =>
//{
//    Console.WriteLine("[消费者] 启动，准备处理数据...");

//    // 这里的 ReadAllAsync 是 .NET 6+ 的高效异步流
//    await foreach (var item in channel.Reader.ReadAllAsync())
//    {
//        await Task.Delay(2000); // 模拟写入数据库的耗时

//        Console.WriteLine($"[消费者] 成功处理并写入数据库: {item}");
//    }
//});

//// 3. 模拟生产者（主线程疯狂接报文）
//for (int i = 1; i <= 20; i++)
//{
//    await channel.Writer.WriteAsync($"设备数据_{i}");
//    Console.WriteLine($"[生产者] 接收到报文 {i}，已存入缓冲区");
//}

//// 告诉通道：没数据了，写完了
//channel.Writer.Complete();

//// 等待消费者把最后的活儿干完
//await consumerTask;

//Console.WriteLine("===== 所有数据处理完毕 =====");
//Console.ReadLine(); 
#endregion

#region Keyed Services
//Console.WriteLine("===== .NET 8 Keyed Services (具名服务) 演示 =====");

//// 1. 构建服务容器 (模拟 WebHost 的配置过程)
//var builder = Host.CreateApplicationBuilder();

//// 2. [关键点]：为同一个接口注册不同的“键控”实现
//builder.Services.AddKeyedSingleton<IMeterReader, ModbusReader>("A_Brand");
//builder.Services.AddKeyedSingleton<IMeterReader, MqttReader>("B_Brand");

//using var host = builder.Build();

//// 3. [场景模拟]：根据设备品牌动态获取处理器
//ProcessDevice("A_Brand", host.Services);
//ProcessDevice("B_Brand", host.Services);

//void ProcessDevice(string brand, IServiceProvider services)
//{
//    // 根据 Key 直接拿到对应的实现，不需要写 if/else
//    var reader = services.GetRequiredKeyedService<IMeterReader>(brand);
//    Console.WriteLine($"[系统启动] 正在为 {brand} 调用处理器...");
//    reader.Read();
//}

//// 定义接口和实现
//public interface IMeterReader { void Read(); }

//public class ModbusReader : IMeterReader
//{
//    public void Read() => Console.WriteLine(">> 正在通过 Modbus 协议读取威胜 A 型电表数据...");
//}

//public class MqttReader : IMeterReader
//{
//    public void Read() => Console.WriteLine(">> 正在通过 MQTT 协议解析威胜 B 型电表报文...");
//} 
#endregion

#region EF Core ExecuteUpdate
//// ==========================================================
//// 3. 主程序
//// ==========================================================
//var builder = Host.CreateApplicationBuilder();

//// 注册数据库
//builder.Services.AddDbContext<WasionDbContext>();

//// 注册具名服务 (Keyed Services)
//builder.Services.AddKeyedScoped<IMeterProcessor, BrandAProcessor>("A_Brand");

//using var host = builder.Build();

//// A. 初始化数据 (模拟产生 1000 条数据)
//using (var scope = host.Services.CreateScope())
//{
//    var db = scope.ServiceProvider.GetRequiredService<WasionDbContext>();
//    await db.Database.EnsureCreatedAsync();
//    if (!await db.Readings.AnyAsync())
//    {
//        var data = Enumerable.Range(1, 1000).Select(i => new MeterReading { Brand = "A_Brand", Value = i, Status = 0 });
//        db.Readings.AddRange(data);
//        await db.SaveChangesAsync();
//        Console.WriteLine(">> 数据库初始化：已插入 1000 条待处理读数。");
//    }
//}

//// B. 调用具名处理器进行“高性能批量更新”
//using (var scope = host.Services.CreateScope())
//{
//    var processor = scope.ServiceProvider.GetRequiredKeyedService<IMeterProcessor>("A_Brand");
//    await processor.ProcessBatchAsync();
//}

//// C. 最终核查数据库结果
//using (var scope = host.Services.CreateScope())
//{
//    var db = scope.ServiceProvider.GetRequiredService<WasionDbContext>();

//    Console.WriteLine("\n[数据库最终结果核查]");
//    var top5 = await db.Readings.Take(5).ToListAsync();

//    foreach (var r in top5)
//    {
//        Console.WriteLine($"ID: {r.Id} | 品牌: {r.Brand} | 状态: {r.Status} (1表示批量结算成功)");
//    }
//}

//Console.WriteLine("\n===== 处理完毕 =====");

//// ==========================================================
//// 1. 数据库定义 (EF Core 8)
//// ==========================================================
//public class MeterReading
//{
//    public int Id { get; set; }
//    public string Brand { get; set; } = "";
//    public double Value { get; set; }
//    public int Status { get; set; } // 0: 待处理, 1: 已结算
//}

//public class WasionDbContext : DbContext
//{
//    public DbSet<MeterReading> Readings => Set<MeterReading>();
//    protected override void OnConfiguring(DbContextOptionsBuilder options)
//        => options.UseSqlite("Data Source=wasion.db");
//}

//// ==========================================================
//// 2. 核心逻辑：利用 EF Core 8 批量操作
//// ==========================================================
//public interface IMeterProcessor { Task ProcessBatchAsync(); }

//public class BrandAProcessor(WasionDbContext db) : IMeterProcessor
//{
//    public async Task ProcessBatchAsync()
//    {
//        // .NET 8 杀手锏：ExecuteUpdate
//        // 场景：将所有品牌为 A 且状态为 0 的读数，一键改为状态 1（结算完成）
//        // 这是一行代码直接发 SQL 给数据库，不查数据到内存，性能极高！
//        int rows = await db.Readings
//            .Where(x => x.Brand == "A_Brand" && x.Status == 0)
//            .ExecuteUpdateAsync(set => set.SetProperty(m => m.Status, 1));

//        Console.WriteLine($">> [处理器 A] 成功批量结算 {rows} 条记录。");
//    }
//} 
#endregion

Console.WriteLine("===== 威胜高性能设备网关监控原型 (net8.0) =====");

public class MaterReading
{
    public int Id { get; set; }
    public string Brand { get; set; } = "";
    public double Value { get; set; }

    public int Status { get; set; } // 0: 待处理, 1: 已结算
}

public class WasionDbContext : DbContext
{
    public DbSet<MaterReading> Readings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=wasion.db");
    }

    // 具名服务注入示例
    public interface IMeterProcessor
    {
        Task<int> ProcessBatchAsync();
    }



}
