# .NET 学习路线（2026 行业对齐版 · 查漏补缺 v2）

> 本大纲结合多份公开的 2026 .NET 开发者路线图修订，并针对大C 的现有基础（阶段 1 已完成）和工作区项目（FreeDemo / AspireMvp）量身调整。
> 初版：2026-11-26；**v2 查漏补缺：2026-11-26**（据大C 指出的 milanm 路线图全面补充）。
> 当前进度见文末。
> **配套 [PLAN.md](PLAN.md)**：本文件管「学什么」，PLAN 管「何时学、怎么算过关、学完留下什么」（里程碑 / 毕业线 / 贯穿项目 / 复习机制）。

## 修订依据（v2 补充后）

初版参考了以下来源的共识部分（已过滤营销性表述）：

| 来源 | 核心观点 |
|---|---|
| LinkedIn《.NET Developer Roadmap for 2026》 | 15 步：C# → .NET 基础 → ASP.NET → DB → Auth → OpenAPI → Redis → 限流 → 测试 → 消息队列 → 设计模式 → 架构 → 可观测性 → 部署 → CI/CD |
| CSDN《C#/.NET 路线在 2026》 | 初级必掌握：OOP、SOLID、async/await、泛型、委托、LINQ、GC、ASP.NET Core、EF Core、SQL、Git、单测 |
| daily.dev《What Every .NET Developer Actually Needs to Know in 2026》 | 重基础：.NET 8/9/10 + ASP.NET Core、DI、认证、集成测试；SQL 基础、消息队列概念、云部署 + CI/CD |
| hqwc《2026 .NET/C# 就业前景与实战学习路线》 | 四阶段：基础 → Web+DB → 进阶现代化(JWT/Redis/Docker/单测) → 拓展深耕(微服务/云/Blazor) |
| Microsoft Learn《.NET 10 新功能》 | .NET 10 是 LTS（支持到 2028-11），C# 14、NativeAOT、AI 生态增强 |

**v2 新增核心来源（大C 于 2026-11-26 指出，初版遗漏，特此补记）：**

| 来源 | 价值 |
|---|---|
| [milanm/DotNet-Developer-Roadmap](https://github.com/milanm/DotNet-Developer-Roadmap)（《.NET Developer Roadmap 2026》，作者为 Microsoft MVP Dr. Milan Milanović） | 17 大主题、260+ 资源、含「junior 必知最小集」；覆盖 .NET 生态演进、通用开发技能(SOLID/设计模式/Clean Code)、日志、通信、后台任务、云、性能与安全等初版遗漏领域。本次据其逐条查漏补缺。 |

**提炼原则**：多份来源一致要求 = 核心；单份来源或明确标注「加分」= 前沿。
**本大纲的取舍**：milanm 路线是「全景地图」（含 Blazor/MAUI 等客户端方向、K8s、GraphQL），本大纲收窄为**后端就业路径**，并把每个阶段绑定到工作区里的具体项目（`FreeDemo` / `AspireMvp`）。

---

## 阶段 0 · .NET 生态认知（v2 新增 · 建议先花 30 分钟读一遍）

来自 milanm 路线特别强调、初版完全遗漏的一块。不懂生态，看版本号和项目文件会一直懵。

- [ ] **.NET 运行时演进**：.NET Framework（仅 Windows，4.8.1 收尾）→ .NET Core（2016，跨平台开源）→ .NET 5（统一）→ **.NET 10（当前 LTS，支持到 2028-11）**
- [ ] **LTS vs STS**：LTS 支持 ≥3 年、STS 支持 2 年，交替发布；.NET 11 / C# 15 已于 2026-11 进入预览（runtime-native async、C# union types、EF Core 11 向量搜索）——**我们当前用 .NET 10 LTS 是正确选择**
- [ ] **.NET Standard**：历史遗留的 API 规范（用于跨运行时共享代码），2.1 是终版；现代项目直接 target `net10.0` 即可
- [ ] **CLR / CIL / JIT / 程序集**：C# 编译成 CIL 存于 `.dll`/`.exe`，运行时由 CLR 用 JIT 转成机器码并执行 GC —— 理解「托管代码」是什么
- [ ] **工具链**：`dotnet` CLI 常用命令、NuGet 包管理机制、TFM（目标框架名，如 `net10.0`）

---

## 第一梯队 · 就业核心（找到工作必备）

多份 2026 路线图一致要求，面试高频考点。

### 阶段 1 · C# 语言基础 —— 进行中（3 课已完成）
- [x] 变量、类型、控制流、方法、类与对象（第一课，7 检查点全绿）
- [x] 集合与 LINQ（第二课，6 检查点全绿）
- [x] 异常与可空类型（第三课，13 检查点全绿）
- [x] **async / await** —— 第四课 10/10 通过（2026-11-26）（milanm 引 Stephen Toub 经典文章）
- [x] **泛型、委托** —— 第四课通过；事件后置到项目实践中（中级 C# 的分水岭）
- [ ] **引用类型 vs 值类型** —— 理解内存模型、装箱拆箱（v2 补）
- [ ] **接口、继承、多态** —— OOP 三大支柱（v2 补，前三课只覆盖了类与对象）
- [ ] **records 与模式匹配、主构造函数、集合表达式** —— 现代 C# 高频语法（v2 补）
- [ ] **文件 I/O 与序列化、多线程与任务并行** —— .NET 基础库 API（v2 补）
- [ ] **C# 14 新特性**：扩展成员、`field` 关键字、null 条件赋值、`Span<T>` 转换（v2 补，了解即可）
- [ ] GC / 内存模型 —— 性能调优基础，可后置

**v2 新增子阶段 · 通用开发技能**（milanm 称其为「coder 与 engineer 的分界线」，初版遗漏）：
- [ ] **SOLID 五原则**（SRP/OCP/LSP/ISP/DIP）—— 面试高频
- [ ] DRY / KISS / YAGNI / 迪米特法则 / 组合优于继承
- [ ] 数据结构与算法基础
- [ ] Clean Code 与重构基础
- [ ] 设计模式：创建型 / 结构型 / 行为型；Repository / Unit of Work 模式

> 建议：async/await + 泛型委托做完（第四课）即可进阶段 2；SOLID/设计模式随阶段 3-4 的项目实践穿插学，不必孤立啃完。

### 阶段 2 · 工具链与控制台实战
- [x] Git / GitHub（已在实际使用，含 SSH、跨设备同步）
- [ ] NuGet 包管理、配置文件、日志
- [ ] **Polly 重试 / 熔断策略、SQLite** —— 拆解 `FreeDemo`
- [ ] **IHttpClientFactory / Microsoft Resilience** —— .NET 内置弹性管道，Polly 的现代替代/搭配（v2 补）

### 阶段 3 · ASP.NET Core Web API
- [ ] Web 基础：HTTP/HTTPS、DNS、请求响应模型、RESTful 设计（状态码、HATEOAS、过滤/排序/分页）（v2 细化）
- [ ] Minimal API（.NET 10 首选轻量方案）、路由、模型绑定、Filters
- [ ] **依赖注入 DI**（框架核心，含生命周期）
- [ ] 中间件、配置系统、**Options 模式**、User Secrets、日志系统
- [ ] **JWT 认证授权 / RBAC / Claims**；Identity、OIDC、Passkeys（.NET 10）（v2 细化）
- [ ] **OpenAPI**（.NET 9+ 内置生成，Swagger 已非默认）+ Scalar UI（v2 修正过时信息）
- [ ] 健康检查（Health Checks）、限流（Rate Limiting）、FluentValidation（v2 补）
- [ ] SDK 客户端：Refit / RestSharp（调用外部 API）（v2 补）

### 阶段 4 · 数据持久化
- [ ] **SQL 基础**：SELECT/WHERE/ORDER BY/GROUP BY/JOIN（Inner/Left/Right/Full）、视图、存储过程、触发器、执行顺序、查询优化器（v2 细化）
- [ ] 数据库设计：范式、键、关系、一致性模型
- [ ] EF Core：DbContext/DbSet、Code First、迁移、变化追踪、关系映射（1-1/1-N/N-N）
- [ ] EF Core 查询：Eager/Explicit/Lazy Loading、AsNoTracking、投影、分页、编译查询、全局过滤器（v2 细化）
- [ ] EF Core 进阶：事务、并发（乐观/悲观锁）、批量更新、原始 SQL（v2 细化）
- [ ] Dapper / ADO.NET（轻量替代方案）（v2 补）
- [ ] SQLite → SQL Server / PostgreSQL（新项目推荐 PostgreSQL）

### 阶段 5 · 测试与工程质量
- [ ] xUnit（v3）/ NUnit / MSTest / TUnit；Microsoft.Testing.Platform（新测试运行器）（v2 细化）
- [ ] Mock：NSubstitute（推荐）/ Moq；断言：Shouldly / Awesome Assertions（v2 补）
- [ ] 集成测试：WebApplicationFactory、Testcontainers（v2 补）
- [ ] 测试数据：Bogus / AutoFixture（v2 补）
- [ ] 其他测试类型（了解）：快照 Verify、变异 Stryker、E2E Playwright、性能 BenchmarkDotNet（v2 补）
- [ ] 拆解 `AspireMvp.Tests`

### 阶段 6 · 工程化与部署（2026 硬要求）
- [ ] Docker：Dockerfile、Compose、Volume、网络；**.NET SDK 容器发布（免 Dockerfile）**、Chiseled 精简镜像（v2 细化）
- [ ] GitHub Actions CI/CD（已在用 GitHub，顺理成章）
- [ ] 构建卫生：Central Package Management、NuGet Audit、dotnet format / analyzers、Dependabot（v2 补）
- [ ] **云基础（v2 新增）**：AWS 或 Azure 择一入门；核心概念——用户/网络/虚机/密钥管理（Key Vault / Managed Identity）、对象存储、Serverless（Functions/Lambda）
- [ ] API 网关与服务发现：YARP / Nginx（v2 补）
- [ ] IaC 基础（了解）：Terraform / Bicep（v2 补）

---

## 第二梯队 · 进阶（从中级到高级的分水岭）

不必急，进公司后再深入。

### 阶段 7 · 缓存、通信与后台任务（v2 大幅扩充）
- [ ] 缓存：MemoryCache、**Hybrid Cache（.NET 10）**、Redis、输出缓存（v2 细化）
- [ ] 通信（v2 新增）：
  - 实时：SignalR、WebSocket、SSE（.NET 10 内置）
  - 同步：HttpClient / IHttpClientFactory
  - 异步消息：RabbitMQ / Kafka / Azure Service Bus；消息总线 MassTransit（推荐）
  - 概念：幂等性、死信队列、消息去重、Queue vs Pub-Sub
- [ ] 后台任务（v2 新增）：BackgroundService（内置）、Hangfire、Quartz、Coravel

### 阶段 8 · 架构、性能与安全（v2 大幅扩充）
- [ ] Clean Architecture / 垂直切片架构 / 模块化单体 / 分层架构
- [ ] DDD、CQRS、事件溯源、Saga、Outbox 模式（了解）（v2 补）
- [ ] 设计模式深入（GoF 23 种）
- [ ] **.NET Aspire** —— 微服务编排、服务发现、Dashboard（拆解 `AspireMvp`）
- [ ] 可观测性：OpenTelemetry（traces/metrics/logs 标准）、Aspire Dashboard、Prometheus + Grafana（v2 细化）
- [ ] 性能（v2 新增）：BenchmarkDotNet、dotnet-counters/trace/dump、PerfView；内存管理、GC、Span<T>、NativeAOT/trimming
- [ ] 安全（v2 新增）：OWASP Top 10、CORS、CSRF、HTTPS/HSTS、Secrets 管理、对称/非对称加密、哈希与签名、NuGet 依赖审计

---

## 第三梯队 · 2026 前沿（加分项，有余力再学）

### 阶段 9 · AI 集成与前沿（v2 修正）
- [ ] .NET 10 / C# 14 新特性（当前环境已是 .NET 10.0.402）；关注 .NET 11 / C# 15 预览
- [ ] **Microsoft.Extensions.AI (MEAI)** —— 统一的 `IChatClient` / `IEmbeddingGenerator` 抽象，**推荐起点**（v2 新增）
- [ ] **Microsoft Agent Framework** —— Semantic Kernel + AutoGen 的统一继任者（2026-04 发布 1.0）；**注意：Semantic Kernel 已进入维护模式，新项目不再首选**（v2 修正初版过时信息）
- [ ] RAG：embeddings、向量搜索（pgvector / Qdrant / EF Core 11）、grounding
- [ ] MCP（Model Context Protocol）C# SDK
- [ ] 本地推理：ONNX Runtime、OllamaSharp、Foundry Local（了解）
- [ ] NativeAOT 性能优化

---

## 刻意不覆盖（方向选择，非遗漏）

milanm 全景路线包含但**本大纲主动排除**，等确定方向再决定：

- **客户端 .NET**：Blazor / MAUI / WPF / WinUI / Uno / Avalonia（后端路径用不上）
- GraphQL / gRPC 深入（REST 扎实后再选学）
- Kubernetes 深入 / Helm / AKS（阶段 6 只要求 Docker + 基础云；K8s 留给运维方向）
- 完整的 23 种设计模式、微服务所有模式（阶段 8 先建立认知地图，用到再深挖）

---

## v2 相对初版的关键增补（速查）

| 变化 | 来源 | 优先级 |
|---|---|---|
| 新增阶段 0「.NET 生态认知」 | milanm | 前置，30 分钟 |
| C# 补引用/值类型、接口继承多态、records/模式匹配、C# 14 | milanm | 核心 |
| 新增「通用开发技能」：SOLID / 设计模式 / Clean Code / 重构 / 算法 | milanm | 核心，贯穿实践 |
| Web 阶段补 HTTP 基础、Options、健康检查/限流、OpenAPI+Scalar、Refit | milanm | 核心 |
| **修正**：Swagger 已非 .NET 9+ 默认，改为内置 OpenAPI + Scalar | milanm | 事实修正 |
| 测试细化：xUnit v3、NSubstitute、WebApplicationFactory、Testcontainers | milanm | 核心 |
| 日志独立成点：Serilog / NLog / LoggerMessage | milanm | 阶段 2-3 穿插 |
| 新增云基础 + API 网关 + IaC | milanm | 核心（云）/了解（IaC） |
| 通信新增 SignalR / 消息队列细节 / 幂等；后台任务独立成节 | milanm | 进阶 |
| 性能与安全独立成节（BenchmarkDotNet / OWASP / CORS / 加密） | milanm | 进阶 |
| **修正**：Semantic Kernel → Microsoft Agent Framework；补 MEAI / MCP / RAG | milanm | 前沿，事实修正 |
| 明确「刻意不覆盖」边界，避免全景路线带来焦虑 | 本大纲 | 心态 |

## 当前进度

阶段 1 已毕业：四课共 36 检查点全绿。当前进行第一次无提示复习（前三课 Exercise.cs 已还原成空白 TODO，凭记忆重写）；复习通过后进阶段 2 拆 `FreeDemo`。
大纲是地图不是枷锁——按实际项目遇到什么就调整顺序。具体排期与验收标准见 [PLAN.md](PLAN.md)。
