// 自动批改：你不用改这个文件。
static class SelfTest
{
    private static int _passed;
    private static int _failed;

    public static void Run()
    {
        Console.WriteLine("===== 练习批改结果 =====");

        Check("练习1  SafeDivide(10, 2) 应得 5", () => Exercise.SafeDivide(10, 2) == 5);
        Check("练习1  SafeDivide(10, 0) 应得 -1（不崩溃）", () => Exercise.SafeDivide(10, 0) == -1);
        Check("练习2  ParseOrMinusOne(\"42\") 应得 42", () => Exercise.ParseOrMinusOne("42") == 42);
        Check("练习2  ParseOrMinusOne(\"abc\") 应得 -1", () => Exercise.ParseOrMinusOne("abc") == -1);
        Check("练习3  DoublePositive(5) 应得 10", () => Exercise.DoublePositive(5) == 10);
        Check("练习3  DoublePositive(-1) 应抛 ArgumentException",
            () =>
            {
                try { Exercise.DoublePositive(-1); return false; }
                catch (ArgumentException) { return true; }
                catch (NotImplementedException) { throw; } // 未完成时交给外层标记
                catch { return false; }
            });
        Check("练习4  NameLength(\"大C\") 应得 2", () => Exercise.NameLength("大C") == 2);
        Check("练习4  NameLength(null) 应得 0", () => Exercise.NameLength(null) == 0);
        Check("练习5  DisplayName(null) 应得 匿名", () => Exercise.DisplayName(null) == "匿名");
        Check("练习5  DisplayName(\"\") 应得 匿名", () => Exercise.DisplayName("") == "匿名");
        Check("练习5  DisplayName(\"大C\") 应得 大C", () => Exercise.DisplayName("大C") == "大C");
        Check("练习6  ScoreText(null) 应得 未录入", () => Exercise.ScoreText(null) == "未录入");
        Check("练习6  ScoreText(95) 应得 分数：95", () => Exercise.ScoreText(95) == "分数：95");

        Console.WriteLine();
        Console.WriteLine($"总计：通过 {_passed} 题，失败 {_failed} 题");
        if (_failed == 0)
            Console.WriteLine("全部通过！第一阶段 C# 语言基础就毕业了！");
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
