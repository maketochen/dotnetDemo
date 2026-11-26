// ===== 第三课参考答案：异常与可空类型 =====
// 对照着看，别照抄——先自己写，卡住了再看。

static class Lesson3Answers
{
    // 练习 1：try/catch 捕获除零异常
    public static int SafeDivide(int a, int b)
    {
        try
        {
            return a / b;
        }
        catch (DivideByZeroException)
        {
            return -1;
        }
    }

    // 练习 2：try/catch 捕获格式异常
    public static int ParseOrMinusOne(string s)
    {
        try
        {
            return int.Parse(s);
        }
        catch (FormatException)
        {
            return -1;
        }
    }

    // 练习 3：主动抛出异常
    public static int DoublePositive(int n)
    {
        if (n < 0)
            throw new ArgumentException("不能是负数");
        return n * 2;
    }

    // 练习 4：?. 与 ?? 组合
    public static int NameLength(string? name) => name?.Length ?? 0;

    // 练习 5：空串兜底
    public static string DisplayName(string? name) =>
        string.IsNullOrEmpty(name) ? "匿名" : name;

    // 练习 6：可空类型 int?
    public static string ScoreText(int? score) =>
        score.HasValue ? $"分数：{score.Value}" : "未录入";
}
