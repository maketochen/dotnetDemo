# 第四课：异步与泛型委托

阶段 1 的最后一课。学完这课，C# 语言基础就正式毕业了。

## 学什么

- **异步**：`async` / `await` / `Task<T>` / `Task.WhenAll` —— 不阻塞线程地等待耗时操作
- **泛型**：`T` 占位符、泛型方法 —— 一套代码服务多种类型
- **委托**：`Func<>` / `Action<>` / Lambda —— 把「方法」当值传递

## 怎么学

1. 读 `Demo.cs`：看知识点回顾和并发实测（三个任务并发的总耗时）。
2. 打开 **`Exercise.cs`**，在 6 个 TODO 处写代码。
3. 终端运行 `dotnet run`，底部显示 10 条批改结果。
4. 全绿了就算过关；卡住先看提示，再翻 `Solutions/` 参考答案。

## 练习清单

| 题 | 考点 | 方法 |
|---|---|---|
| 1 | async/await 基本用法 | `GreetAfterDelay` |
| 2 | Task.WhenAll 并发 | `FetchBothAsync` |
| 3 | async Task<T> | `SumAsync` |
| 4 | Func 委托 + Lambda | `Apply` |
| 5 | Action 委托 | `ForEach` |
| 6 | 泛型方法 + 委托组合 | `FirstMatch<T>` |

## 一句话理解

- `await` 不是「等得更快的 Sleep」，而是「等的时候把线程还回去干别的活」。
- 委托是「把行为打包成值」——你传进去的不是一个数，而是一段逻辑。
- 泛型是「把类型当参数」——`FirstMatch<T>` 对 int、string、自定义对象都适用。
