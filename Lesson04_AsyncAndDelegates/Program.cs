// ===== 第四课：异步与泛型委托 =====
// 运行方式：在本文件夹打开终端，输入 dotnet run

Demo.Show().GetAwaiter().GetResult();
Console.WriteLine();
SelfTest.Run().GetAwaiter().GetResult();

Console.WriteLine();
Console.Write("按回车键退出...");
Console.ReadLine();
