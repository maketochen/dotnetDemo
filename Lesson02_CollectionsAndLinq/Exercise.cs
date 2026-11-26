// ★★★ 这是你的练习文件，只改这里 ★★★
// 每个方法下面的 TODO 就是要你写的代码。
// 写完后运行 dotnet run，SelfTest 会自动批改。

static class Exercise
{
    // 练习 1：返回列表里所有的偶数
    // 提示：return nums.Where(n => ...).ToList();
    public static List<int> EvenNumbers(List<int> nums)
    {
        throw new NotImplementedException(); // TODO
    }

    // 练习 2：返回分数及格（>=60）的学生列表
    // 提示：students.Where(s => ...).ToList()
    public static List<Student> PassedStudents(List<Student> students)
    {
        throw new NotImplementedException(); // TODO
    }

    // 练习 3：只要所有学生的名字，返回字符串列表
    // 提示：students.Select(s => s.Name).ToList()
    public static List<string> AllNames(List<Student> students)
    {
        throw new NotImplementedException(); // TODO
    }

    // 练习 4：把学生按分数从高到低排序，返回名字列表
    // 提示：先 OrderByDescending(s => s.Score)，再 Select(s => s.Name)
    public static List<string> NamesByScoreDesc(List<Student> students)
    {
        throw new NotImplementedException(); // TODO
    }

    // 练习 5：返回所有学生的平均分（double）
    // 提示：students.Average(s => s.Score)
    public static double AverageScore(List<Student> students)
    {
        throw new NotImplementedException(); // TODO
    }

    // 练习 6：返回最高分学生的名字
    // 提示：用 OrderByDescending(...).First().Name，或 MaxBy(...)
    public static string TopStudentName(List<Student> students)
    {
        throw new NotImplementedException(); // TODO
    }
}
