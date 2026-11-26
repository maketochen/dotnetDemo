// ★★★ 这是你的练习文件，只改这里 ★★★
// 每个方法下面的 TODO 就是要你写的代码。
// 写完后运行 dotnet run，SelfTest 会自动批改。

using System.Threading.Tasks;

static class Exercise
{
    // 练习 1：异步问候。等 50ms 后返回「你好，{name}」。
    // 提示：方法已标 async，先 await Task.Delay(50); 再 return $"你好，{name}";
    public static async Task<string> GreetAfterDelay(string name)
    {
        await Task.Delay(50);
        return $"你好，{name}";
    }

    // 练习 2：用 Task.WhenAll 并发获取两个数，返回结果数组。
    // 已提供 SimulateFetch(int)（等 30ms 后返回原值），你只需把两个任务并发跑起来。
    // 提示：return await Task.WhenAll(SimulateFetch(3), SimulateFetch(7));
    public static async Task<int[]> FetchBothAsync()
    {
        return await Task.WhenAll(SimulateFetch(3), SimulateFetch(7));
    }

    // 练习 3：异步求和。等 20ms 后返回数组元素之和。
    // 提示：await Task.Delay(20); return nums.Sum();
    public static async Task<int> SumAsync(int[] nums)
    {
        await Task.Delay(20);
        return nums.Sum();
    }

    // 练习 4：Func 委托 —— 把「怎么算」当参数传进来，返回 op(a, b) 的结果。
    // 提示：return op(a, b);
    public static int Apply(int a, int b, Func<int, int, int> op)
    {
        return op(a, b);
    }

    // 练习 5：Action 委托 —— 对每个元素调用一次 action（没有返回值）。
    // 提示：foreach (var item in items) action(item);
    public static void ForEach(int[] items, Action<int> action)
    {
        foreach (var item in items)
        {
            action(item);
        }
    }

    // 练习 6：泛型方法 —— 返回第一个满足 predicate 的元素，没有就返回默认值。
    // 提示：foreach (var item in items) if (predicate(item)) return item; 最后 return default!;
    public static T FirstMatch<T>(T[] items, Func<T, bool> predicate)
    {
        foreach (var item in items)
        {
            if (predicate(item))
            {
                return item;
            }
        }
      //  return default!;
    }

    // 辅助方法（不用改）：模拟一个耗时 30ms 的异步获取
    private static async Task<int> SimulateFetch(int value)
    {
        await Task.Delay(30);
        return value;
    }
}
