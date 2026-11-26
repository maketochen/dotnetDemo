// 讲解示例：这一部分只读，不用改。
static class Demo
{
    public static void Show()
    {
        Console.WriteLine("===== 第二课知识点回顾 =====");
        Console.WriteLine("1. List<T>：动态列表，用 { } 初始化，Add 添加，Count 取长度");
        Console.WriteLine("2. lambda：s => s.Score >= 60，读作「对每个 s，判断分数是否及格」");
        Console.WriteLine("3. Where：筛选，保留满足条件的元素");
        Console.WriteLine("4. Select：投影，把每个元素转换成另一种形态");
        Console.WriteLine("5. OrderBy / OrderByDescending：升序 / 降序排序");
        Console.WriteLine("6. 聚合：Sum / Average / Max / Min / Count 把一堆值算成一个值");
        Console.WriteLine();
        Console.WriteLine("下面是 6 道练习题，请到 Exercise.cs 里填空。");
        Console.WriteLine("改完后再运行一次 dotnet run，自检会告诉你对不对。");
    }
}

// 学生数据模型（练习会用到）
class Student
{
    public string Name { get; set; } = "";
    public int Score { get; set; }

    public override string ToString() => $"{Name}({Score})";
}
