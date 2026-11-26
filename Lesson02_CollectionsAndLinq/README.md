# 第二课：集合与 LINQ

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
5. 重复 2–4，直到全部通过。

## 规则

- **只改 `Exercise.cs`**。`Demo.cs`、`SelfTest.cs`、`Program.cs` 不用动。
- 不会的题可以先跳过，不影响其他题批改。
- `Student` 类在 `Demo.cs` 里定义好了，直接用 `s.Name`、`s.Score` 访问。

## 练习题

| 题号 | 考点 | 方法 |
|---|---|---|
| 1 | Where 过滤 | `EvenNumbers` |
| 2 | Where + 对象 | `PassedStudents` |
| 3 | Select 投影 | `AllNames` |
| 4 | 链式调用 + 排序 | `NamesByScoreDesc` |
| 5 | Average 聚合 | `AverageScore` |
| 6 | 排序 + 取第一个 | `TopStudentName` |
