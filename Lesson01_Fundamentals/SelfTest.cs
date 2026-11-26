// 自动批改：运行 dotnet run 后会调用这里的 Check。
// 你不用改这个文件。它会逐个调用你在 Exercise.cs 里写的方法，
// 把结果和期望值比较，打印「通过 / 失败」。

static class SelfTest
{
    private static int _passed;
    private static int _failed;

    public static void Run()
    {
        Console.WriteLine("===== 练习批改结果 =====");

        Check("练习1  Add(3, 5) 应得 8", () => Exercise.Add(3, 5) == 8);
        Check("练习2  IsPass(60) 应得 true", () => Exercise.IsPass(60) == true);
        Check("练习2  IsPass(59) 应得 false", () => Exercise.IsPass(59) == false);
        Check("练习3  Greet(\"大C\") 应得 你好，大C！", () => Exercise.Greet("大C") == "你好，大C！");
        Check("练习4  GetMax(7, 12) 应得 12", () => Exercise.GetMax(7, 12) == 12);
        Check("练习5  SumTo(5) 应得 15", () => Exercise.SumTo(5) == 15);
        Check("练习6  AddOneEach([1,2,3]) 应得 [2,3,4]",
            () => Exercise.AddOneEach(new[] { 1, 2, 3 }).SequenceEqual(new[] { 2, 3, 4 }));

        Console.WriteLine();
        Console.WriteLine($"总计：通过 {_passed} 题，失败 {_failed} 题");
        if (_failed == 0)
            Console.WriteLine("全部通过！可以做下一课了。");
        else
            Console.WriteLine("有失败的题：回去看提示，改完 Exercise.cs 再运行一次。");
    }

    private static void Check(string label, Func<bool> test)
    {
        bool ok;
        try
        {
            ok = test();
        }
        catch (NotImplementedException)
        {
            ok = false;
            label += "（未完成）";
        }
        catch (Exception ex)
        {
            ok = false;
            label += $"（报错：{ex.GetType().Name}）";
        }

        Console.WriteLine($"  {(ok ? "[通过]" : "[失败]")} {label}");
        if (ok) _passed++; else _failed++;
    }
}
