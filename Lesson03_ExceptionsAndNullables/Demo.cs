// 讲解示例：这一部分只读，不用改。
static class Demo
{
    public static void Show()
    {
        Console.WriteLine("===== 第三课知识点回顾 =====");
        Console.WriteLine("【异常】程序出错时的自救机制，避免整个程序崩溃");
        Console.WriteLine("1. try { 可能出错的代码 } catch (异常类型 e) { 出错后怎么办 }");
        Console.WriteLine("2. throw new 异常类型(\"消息\")：主动抛出异常");
        Console.WriteLine("3. finally { ... }：无论是否出错都会执行，常放清理代码");
        Console.WriteLine("4. 常见异常：DivideByZeroException / FormatException / NullReferenceException");
        Console.WriteLine();
        Console.WriteLine("【可空类型】优雅地表示「没有值」");
        Console.WriteLine("5. T?：值类型可以装 null，如 int? score = null");
        Console.WriteLine("6. ?. 空条件：obj?.Name，obj 为 null 时返回 null 而不是崩溃");
        Console.WriteLine("7. ?? 空合并：a ?? b，a 为 null 时用 b 兜底");
        Console.WriteLine();
        Console.WriteLine("下面是 6 道练习题，请到 Exercise.cs 里填空。");
        Console.WriteLine("改完后再运行一次 dotnet run，自检会告诉你对不对。");
    }
}
