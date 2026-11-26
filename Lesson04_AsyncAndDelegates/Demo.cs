// 讲解示例：这一部分只读，不用改。
static class Demo
{
    public static async Task Show()
    {
        Console.WriteLine("===== 第四课知识点回顾 =====");
        Console.WriteLine("【异步】不阻塞线程地等待耗时操作（IO、网络、数据库）");
        Console.WriteLine("1. async Task / async Task<T>：标记一个方法是异步的");
        Console.WriteLine("2. await：等结果，但把线程还回线程池，等好了再回来继续执行");
        Console.WriteLine("3. Task.Delay(毫秒)：异步版的 Thread.Sleep，用来模拟耗时操作");

        Console.WriteLine();
        Console.WriteLine("【实测】三个任务并发执行，总耗时约等于最慢的那个，而不是三者之和：");
        var sw = System.Diagnostics.Stopwatch.StartNew();
        Task<int> a = SimulateWork("A", 300);
        Task<int> b = SimulateWork("B", 200);
        Task<int> c = SimulateWork("C", 100);
        int[] results = await Task.WhenAll(a, b, c);
        sw.Stop();
        Console.WriteLine($"  结果 [{string.Join(", ", results)}]，总耗时 {sw.ElapsedMilliseconds} ms");
        Console.WriteLine("  串行需 600ms，并发只要 ~300ms —— 这就是 await 的价值");

        Console.WriteLine();
        Console.WriteLine("【泛型】把类型当参数传，一套代码服务多种类型");
        Console.WriteLine("4. List<T>、Task<T>：T 是占位符，用时换成 int / string / 自定义类");
        Console.WriteLine("5. 泛型方法：T First<T>(T[] items)，调用时 int n = First(new[]{1,2})");

        Console.WriteLine();
        Console.WriteLine("【委托】把「方法」当值传递 —— 传的是行为，不是数据");
        Console.WriteLine("6. Func<in, out>：有返回值的委托，如 Func<int,int,int> 接收两个 int 返回一个 int");
        Console.WriteLine("7. Action<in>：无返回值的委托，如 Action<string> 接收 string 不返回");
        Console.WriteLine("8. Lambda：x => x * 2 是委托的简写，读作「对 x，返回 x 乘 2」");

        Console.WriteLine();
        Console.WriteLine("下面是 6 道练习题，请到 Exercise.cs 里填空。");
        Console.WriteLine("改完后再运行一次 dotnet run，自检会告诉你对不对。");
    }

    // 模拟一个耗时工作：等待指定毫秒后返回编号
    private static async Task<int> SimulateWork(string name, int delayMs)
    {
        await Task.Delay(delayMs);
        Console.WriteLine($"  任务 {name} 完成");
        return delayMs;
    }
}
