# .NET 学习路线（2026 行业对齐版）

> 本大纲结合 2026 年多份公开的 .NET 开发者路线图修订，并针对大C 的现有基础（阶段 1 已完成）和工作区项目（FreeDemo / AspireMvp）量身调整。
> 修订日期：2026-11-26

## 修订依据

参考了以下公开路线图的共识部分（过滤掉营销性表述）：

| 来源 | 核心观点 |
|---|---|
| LinkedIn《.NET Developer Roadmap for 2026》 | 15 步：C# → .NET 基础 → ASP.NET → DB → Auth → OpenAPI → Redis → 限流 → 测试 → 消息队列 → 设计模式 → 架构 → 可观测性 → 部署 → CI/CD |
| CSDN《C#/.NET 路线在 2026》 | 初级必掌握：OOP、SOLID、async/await、泛型、委托、LINQ、GC、ASP.NET Core、EF Core、SQL、Git、单测 |
| daily.dev《What Every .NET Developer Actually Needs to Know in 2026》 | 重基础：.NET 8/9/10 + ASP.NET Core、DI、认证、集成测试；SQL 基础、消息队列概念、云部署 + CI/CD |
| hqwc《2026 .NET/C# 就业前景与实战学习路线》 | 四阶段：基础 → Web+DB → 进阶现代化(JWT/Redis/Docker/单测) → 拓展深耕(微服务/云/Blazor) |
| Microsoft Learn《.NET 10 新功能》 | .NET 10 是 LTS（支持 3 年），C# 14、NativeAOT、AI 生态增强 |
| LinkedIn / 博客园 2026 栈盘点 | 前沿：Clean Architecture、DDD、CQRS、Semantic Kernel、OpenTelemetry、Aspire |

**提炼原则**：多份来源一致要求 = 核心；单份来源或明确标注「加分」= 前沿。

---

## 第一梯队 · 就业核心（找到工作必备）

多份 2026 路线图一致要求，面试高频考点。

### 阶段 1 · C# 语言基础 —— 已完成
- [x] 变量、类型、控制流、方法、类与对象（第一课）
- [x] 集合与 LINQ（第二课）
- [x] 异常与可空类型（第三课）
- [ ] **async / await** —— 行业公认必掌握，进 Web API 前补上
- [ ] **泛型、委托、事件** —— 中级 C# 的分水岭
- [ ] GC / 内存模型 —— 性能调优基础，可后置

### 阶段 2 · 工具链与控制台实战
- Git / GitHub（已在实际使用）
- NuGet 包管理、配置文件、日志
- Polly 重试策略、SQLite —— 拆解 `FreeDemo`

### 阶段 3 · ASP.NET Core Web API
- Minimal API、路由、模型绑定
- **依赖注入 DI**（框架核心）
- 中间件、配置系统、日志系统
- **JWT 认证授权 / RBAC**（行业硬要求）
- Swagger / OpenAPI 文档

### 阶段 4 · 数据持久化
- EF Core：Code First、迁移、查询优化
- **原生 SQL、索引、事务、慢查询优化**（面试必问）
- SQLite → SQL Server / PostgreSQL

### 阶段 5 · 测试与工程质量
- xUnit 单元测试、Moq 模拟依赖
- 集成测试
- 拆解 `AspireMvp.Tests`

### 阶段 6 · 工程化与部署（2026 新增硬要求）
- Docker 容器化、编写 Dockerfile
- GitHub Actions CI/CD
- 容器镜像发布与部署

---

## 第二梯队 · 进阶（从中级到高级的分水岭）

不必急，进公司后再深入。

### 阶段 7 · 缓存与消息中间件（新增）
- Redis 缓存热点数据
- RabbitMQ / Kafka 消息队列
- 幂等性、消息可靠性

### 阶段 8 · 架构与可观测性
- Clean Architecture / 垂直切片架构
- DDD、CQRS、设计模式
- **.NET Aspire** —— 微服务编排（拆解 `AspireMvp`）
- OpenTelemetry / Prometheus / Grafana 可观测性

---

## 第三梯队 · 2026 前沿（加分项，有余力再学）

### 阶段 9 · AI 集成与前沿（新增）
- .NET 10 / C# 14 新特性（当前环境已是 .NET 10.0.402）
- Semantic Kernel / Microsoft.Extensions.AI
- Microsoft Agent Framework、RAG 应用
- NativeAOT 性能优化

---

## 与旧六阶段大纲的差异

| 变化 | 说明 |
|---|---|
| async/await 补回阶段 1 | 旧版曾推迟，行业共识要求前置 |
| 新增 JWT 认证 | 旧版 Web API 阶段缺失 |
| 数据阶段补原生 SQL | 旧版只有 EF Core |
| 新增阶段 6 工程化 | Docker / CI/CD 是 2026 硬要求 |
| 新增阶段 7 缓存消息 | Redis / 消息队列为进阶必备 |
| Aspire 移到阶段 8 | 与架构、可观测性归为同一梯队更合理 |
| 新增阶段 9 前沿 | AI 集成等 2026 新趋势，非入门必需 |

## 当前进度

阶段 1 已完成（三课 26 检查点全绿）。下一步：补 async/await 与泛型委托，然后进入阶段 2。
