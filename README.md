# .NET 从零学习工作区

大C 和小d 的学习空间。所有课程按文件夹分开，每课都带「讲解 + 练习 + 自动批改」。

## 目录结构

```
dotnetDemo/
├── Lesson01_Fundamentals/       第一课：变量 / 类型 / 控制流 / 方法 / 类
├── Lesson02_CollectionsAndLinq/ 第二课：集合 / LINQ
├── Solutions/                   参考答案库（做完练习再对照）
├── FreeDemo/                    早期示例：Polly 重试 + SQLite（阶段 2 会拆）
├── AspireMvp/                   Aspire 解决方案（阶段 6 会拆）
└── .workbuddy/memory/           学习进度记忆
```

## 每课怎么学

1. 进入课程文件夹，先读 `Demo.cs`（知识点回顾）和 `README.md`。
2. 打开 **`Exercise.cs`**，在 TODO 处自己写代码。
3. 终端运行 `dotnet run`，底部会显示自动批改结果。
4. 全绿了再进下一课；卡住就看 `Solutions/` 里的参考答案。

## 六阶段大纲

1. C# 语言基础 ← 当前在学（第 1–2 课已完成框架）
2. 工具链与控制台实战（拆 `FreeDemo`）
3. Web API（从零搭待办 API）
4. 数据持久化（EF Core + SQLite）
5. 测试与工程质量（拆 `AspireMvp.Tests`）
6. Aspire 微服务编排（拆 `AspireMvp`）

## 跨设备同步

- 仓库：`git@github.com:maketochen/dotnetDemo.git`
- 开工前：`git pull`
- 收工后：`git add -A && git commit -m "说明" && git push`
