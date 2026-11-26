// 自动批改：你不用改这个文件。
static class SelfTest
{
    private static int _passed;
    private static int _failed;

    private static List<Student> SampleStudents() => new List<Student>
    {
        new Student { Name = "小明", Score = 85 },
        new Student { Name = "小红", Score = 92 },
        new Student { Name = "小刚", Score = 58 },
        new Student { Name = "小丽", Score = 76 },
    };

    public static void Run()
    {
        Console.WriteLine("===== 练习批改结果 =====");

        Check("练习1  EvenNumbers([1,2,3,4]) 应得 [2,4]",
            () => Exercise.EvenNumbers(new List<int> { 1, 2, 3, 4 }).SequenceEqual(new[] { 2, 4 }));

        var students = SampleStudents();
        Check("练习2  PassedStudents 应得 3 人（85,92,76）",
            () => Exercise.PassedStudents(students).Count == 3
                  && Exercise.PassedStudents(students).All(s => s.Score >= 60));

        Check("练习3  AllNames 应得 小明,小红,小刚,小丽",
            () => Exercise.AllNames(students).SequenceEqual(new[] { "小明", "小红", "小刚", "小丽" }));

        Check("练习4  NamesByScoreDesc 应得 小红,小明,小丽,小刚",
            () => Exercise.NamesByScoreDesc(students).SequenceEqual(new[] { "小红", "小明", "小丽", "小刚" }));

        Check("练习5  AverageScore 应得 77.75",
            () => Math.Abs(Exercise.AverageScore(students) - 77.75) < 0.001);

        Check("练习6  TopStudentName 应得 小红",
            () => Exercise.TopStudentName(students) == "小红");

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
