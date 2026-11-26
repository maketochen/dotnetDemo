# .NET 从零学习工作区

大C 和小d 的学习空间。所有课程按文件夹分开，每课都带「讲解 + 练习 + 自动批改」。

## 目录结构

```
dotnetDemo/
├── Lesson01_Fundamentals/       第一课：变量 / 类型 / 控制流 / 方法 / 类
├── Lesson02_CollectionsAndLinq/ 第二课：集合 / LINQ
├── Lesson03_ExceptionsAndNullables/ 第三课：异常 / 可空类型（学完这课基础阶段毕业）
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

## 学习路线

已结合 2026 年行业路线图修订为**九阶段三梯队**，详见 [ROADMAP.md](ROADMAP.md)。

- **第一梯队 · 就业核心**：阶段 1（已完成）→ 2 工具链 → 3 Web API → 4 数据持久化 → 5 测试 → 6 工程化部署
- **第二梯队 · 进阶**：阶段 7 缓存与消息 → 8 架构与可观测性
- **第三梯队 · 前沿**：阶段 9 AI 集成与 .NET 10 新特性

当前进度：阶段 1 完成，下一步补 async/await 与泛型委托。

## 跨设备同步

- 仓库：`git@github.com:maketochen/dotnetDemo.git`
- 开工前：`git pull`
- 收工后：`git add -A && git commit -m "说明" && git push`
