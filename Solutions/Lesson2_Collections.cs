// ===== 第二课：集合与 LINQ =====
// 这个文件演示如何处理「一组数据」。
// 为了不和 Program.cs 的顶层语句冲突，这里用一个静态类 + Main 风格的入口方法。
// 在本课里，我们把 Program.cs 的内容暂时注释掉，用这个文件当入口来运行。

// 一个简单的数据模型：学生
class Student
{
    public string Name { get; set; } = "";
    public int Score { get; set; }

    // 重写 ToString，方便打印时直接显示内容
    public override string ToString() => $"{Name}({Score})";
}

static class Lesson2
{
    public static void Run()
    {
        // ===== 1. List<T>：动态数组 =====
        // 和数组 int[] 不同，List 可以随时 Add / Remove，长度不固定
        List<Student> students = new List<Student>
        {
            new Student { Name = "小明", Score = 85 },
            new Student { Name = "小红", Score = 92 },
            new Student { Name = "小刚", Score = 58 },
            new Student { Name = "小丽", Score = 76 },
            new Student { Name = "小强", Score = 95 },
        };

        // 集合初始化器：上面 { ... } 里的每一项都会 Add 进去
        Console.WriteLine($"共有 {students.Count} 名学生");
        Console.WriteLine("全部学生：" + string.Join("、", students));
        Console.WriteLine();

        // ===== 2. LINQ 的 Where：筛选 =====
        // s => s.Score >= 60 是一个「lambda 表达式」，读作「对于每一个 s，判断分数是否及格」
        // Where 会保留所有满足条件的元素，返回一个新的集合
        var passed = students.Where(s => s.Score >= 60);
        Console.WriteLine("及格的学生：" + string.Join("、", passed));

        // ===== 3. LINQ 的 Select：投影 / 转换 =====
        // Select 把每个元素变成另一种东西。这里把 Student 变成名字字符串
        var names = students.Select(s => s.Name);
        Console.WriteLine("所有名字：" + string.Join("、", names));
        Console.WriteLine();

        // ===== 4. 链式调用：把管道串起来 =====
        // 找出及格的学生，按分数从高到低排序，只要名字
        var topNames = students
            .Where(s => s.Score >= 60)          // 第一步：过滤
            .OrderByDescending(s => s.Score)    // 第二步：降序排序
            .Select(s => s.Name);               // 第三步：取名字

        Console.WriteLine("及格者按分数排名：" + string.Join(" → ", topNames));

        // ===== 5. 聚合操作：从一堆值算出一个值 =====
        int average = (int)students.Average(s => s.Score); // 平均分
        int highest = students.Max(s => s.Score);          // 最高分
        int lowest = students.Min(s => s.Score);           // 最低分
        int passedCount = students.Count(s => s.Score >= 60); // 及格人数

        Console.WriteLine();
        Console.WriteLine($"平均分 {average}，最高 {highest}，最低 {lowest}，及格 {passedCount} 人");

        // ===== 6. First / FirstOrDefault：取第一个匹配项 =====
        // First 找不到会抛异常；FirstOrDefault 找不到返回默认值（这里 Student 是引用类型，返回 null）
        Student? topStudent = students.FirstOrDefault(s => s.Score == highest);
        Console.WriteLine($"最高分得主：{topStudent?.Name}"); // ?. 是「非空才访问」，避免 null 报错
    }
}
