# 第三课：异常与可空类型

## 怎么学

1. 打开 `Demo.cs` 看一遍知识点回顾（不用改）。
2. 打开 **`Exercise.cs`**，这是你写代码的地方。每个方法下面有 TODO 和提示。
3. 在本文件夹打开终端，运行：

   ```
   dotnet run
   ```

4. 看底部的「练习批改结果」：
   - `[通过]` —— 对了
   - `[失败]（未完成）` —— 你还没写这个方法
   - `[失败]` —— 写了但不符预期（或抛异常），回去改
5. 重复 2–4，直到全部通过。这一课过了，**C# 语言基础阶段就毕业了**。

## 规则

- **只改 `Exercise.cs`**。`Demo.cs`、`SelfTest.cs`、`Program.cs` 不用动。
- 不会的题可以先跳过，不影响其他题批改。
- 卡住了看 `Solutions/` 里的参考答案（第三课答案稍后补充）。

## 练习题

| 题号 | 考点 | 方法 |
|---|---|---|
| 1 | try/catch 除零异常 | `SafeDivide` |
| 2 | try/catch 格式异常 | `ParseOrMinusOne` |
| 3 | throw 主动抛异常 | `DoublePositive` |
| 4 | ?. 与 ?? 组合 | `NameLength` |
| 5 | 空串兜底 | `DisplayName` |
| 6 | 可空类型 int? | `ScoreText` |
