// ★★★ 这是你的练习文件，只改这里 ★★★
// 每个方法下面的 TODO 就是要你写的代码。
// 写完后运行 dotnet run，SelfTest 会自动批改。

static class Exercise
{
    // 练习 1：安全除法。b 为 0 时不要崩溃，返回 -1。
    // 提示：把 a / b 放进 try，catch (DivideByZeroException) { return -1; }
    public static int SafeDivide(int a, int b)
    {
        try
        {
            return a / b;
        }
        catch (System.DivideByZeroException)
        {
            return -1;
        }
    }

    // 练习 2：把字符串转成整数。转不了（如 "abc"）时返回 -1，不要崩溃。
    // 提示：int.Parse(s) 放 try，catch (FormatException) 返回 -1
    public static int ParseOrMinusOne(string s)
    {
        try
        {
            return int.Parse(s);
        }
        catch (System.FormatException)
        {
            return -1;
        }
    }

    // 练习 3：主动抛异常。n 为负数时抛出 ArgumentException("不能是负数")，否则返回 n * 2。
    // 提示：if (n < 0) throw new ArgumentException("不能是负数");
    public static int DoublePositive(int n)
    {

        return n < 0 ? throw new ArgumentException("不能是负数") : n * 2;

    }

    // 练习 4：获取名字长度。name 为 null 时返回 0（用 ?. 和 ?? 组合）。
    // 提示：return name?.Length ?? 0;
    public static int NameLength(string? name)
    {
        return name?.Length ?? 0;
    }

    // 练习 5：兜底名字。name 为 null 或空串时返回 "匿名"，否则返回 name。
    // 提示：string.IsNullOrEmpty(name) ? "匿名" : name
    public static string DisplayName(string? name)
    {
        return string.IsNullOrEmpty(name) ? "匿名" : name;
    }

    // 练习 6：可空分数的描述。score 为 null 返回 "未录入"，否则返回 "分数：{值}"。
    // 提示：用 if (!score.HasValue) 或 score == null 判断，取值用 score.Value
    public static string ScoreText(int? score)
    {
        return score == null ? "未录入" : $"分数：{score.Value}";
    }
}
