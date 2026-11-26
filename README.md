# .NET 从零学习工作区

大C 和小d 的学习空间。所有课程按文件夹分开，每课都带「讲解 + 练习 + 自动批改」。

## 目录结构

```
dotnetDemo/
├── Lesson01_Fundamentals/       第一课：变量 / 类型 / 控制流 / 方法 / 类
├── Lesson02_CollectionsAndLinq/ 第二课：集合 / LINQ
├── Lesson03_ExceptionsAndNullables/ 第三课：异常 / 可空类型
├── Lesson04_AsyncAndDelegates/  第四课：异步 / 泛型 / 委托（学完这课基础阶段毕业）
├── Solutions/                   参考答案库 + Review/ 复习备份（做完练习再对照）
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

两份文档，分工不同：

- **[ROADMAP.md](ROADMAP.md)** —— 「学什么」：阶段 0 + 九阶段三梯队的完整知识地图（v2 查漏补缺版）。
- **[PLAN.md](PLAN.md)** —— 「怎么走」：按每周 3–5 小时排的里程碑、每阶段毕业线、贯穿式 TodoApi 项目、每 3 课一次的无提示复习机制。

- **阶段 0 · 生态认知**：.NET 运行时演进 / LTS 与 STS / CLR / NuGet（v2 新增）
- **第一梯队 · 就业核心**：阶段 1（进行中）→ 2 工具链 → 3 Web API → 4 数据持久化 → 5 测试 → 6 工程化与云部署
- **第二梯队 · 进阶**：阶段 7 缓存/通信/后台任务 → 8 架构/性能/安全
- **第三梯队 · 前沿**：阶段 9 AI 集成（MEAI / Agent Framework / MCP）

v2 已据 [milanm 的 2026 路线图](https://github.com/milanm/DotNet-Developer-Roadmap) 逐条查漏补缺，并修正两处过时信息（Swagger 已非默认、Semantic Kernel 进入维护模式）。

当前进度：阶段 1 第四课（异步与泛型委托）已就绪待作答，前三课 26 检查点全绿。里程碑排期见 [PLAN.md](PLAN.md)。

## 跨设备同步

- 仓库：`git@github.com:maketochen/dotnetDemo.git`
- 开工前：`git pull`
- 收工后：`git add -A && git commit -m "说明" && git push`
