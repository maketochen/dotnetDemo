// 自动批改：你不用改这个文件。
static class SelfTest
{
    private static int _passed;
    private static int _failed;

    public static async Task Run()
    {
        Console.WriteLine("===== 练习批改结果 =====");

        await CheckAsync("练习1  GreetAfterDelay(\"大C\") 应得 你好，大C",
            async () => await Exercise.GreetAfterDelay("大C") == "你好，大C");

        await CheckAsync("练习2  FetchBothAsync() 应得 [3, 7]",
            async () =>
            {
                int[] r = await Exercise.FetchBothAsync();
                return r.Length == 2 && r[0] == 3 && r[1] == 7;
            });

        await CheckAsync("练习3  SumAsync([1,2,3,4]) 应得 10",
            async () => await Exercise.SumAsync(new[] { 1, 2, 3, 4 }) == 10);

        await CheckAsync("练习3  SumAsync([]) 应得 0",
            async () => await Exercise.SumAsync(Array.Empty<int>()) == 0);

        await CheckAsync("练习4  Apply(3,4,加法) 应得 7",
            () => Task.FromResult(Exercise.Apply(3, 4, (a, b) => a + b) == 7));

        await CheckAsync("练习4  Apply(3,4,乘法) 应得 12",
            () => Task.FromResult(Exercise.Apply(3, 4, (a, b) => a * b) == 12));

        await CheckAsync("练习5  ForEach 应对每个元素调用一次 action",
            () =>
            {
                int sum = 0, count = 0;
                Exercise.ForEach(new[] { 1, 2, 3, 4 }, n => { sum += n; count++; });
                return Task.FromResult(sum == 10 && count == 4);
            });

        await CheckAsync("练习6  FirstMatch 找第一个偶数应得 2",
            () => Task.FromResult(
                Exercise.FirstMatch(new[] { 1, 2, 3, 4 }, n => n % 2 == 0) == 2));

        await CheckAsync("练习6  FirstMatch 找不到应得默认值 0",
            () => Task.FromResult(
                Exercise.FirstMatch(new[] { 1, 3, 5 }, n => n % 2 == 0) == 0));

        await CheckAsync("练习6  FirstMatch 能处理 string 泛型",
            () => Task.FromResult(
                Exercise.FirstMatch(new[] { "a", "bb", "ccc" }, s => s.Length == 2) == "bb"));

        Console.WriteLine();
        Console.WriteLine($"总计：通过 {_passed} 题，失败 {_failed} 题");
        if (_failed == 0)
            Console.WriteLine("全部通过！C# 语言基础阶段正式毕业！");
        else
            Console.WriteLine("有失败的题：回去看提示，改完 Exercise.cs 再运行一次。");
    }

    private static async Task CheckAsync(string label, Func<Task<bool>> test)
    {
        bool ok;
        try
        {
            ok = await test();
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
