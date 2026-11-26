// ===== 第一课：从 Hello World 开始 =====
// 这一行就是整个程序的入口。Console 是类，WriteLine 是它的一个方法，
// 括号里放要输出到屏幕的内容，双引号表示一段文本（字符串）。
Console.WriteLine("Hello, World!");
Console.WriteLine();

// ===== 1. 变量与类型 =====
// 变量 = 一个装数据的盒子。声明格式：类型 名字 = 值;
string name = "大C";      // 文本
int age = 30;              // 整数
double score = 95.5;       // 小数
bool isLearning = true;    // 真 / 假

// $"..." 叫字符串插值：{变量名} 会被替换成变量的值
Console.WriteLine($"你好，{name}！你今年 {age} 岁，得分 {score}。");
Console.WriteLine($"正在学习？{isLearning}");
Console.WriteLine();

// ===== 2. 控制流：条件判断 =====
// if 后面跟一个条件，满足就执行大括号里的代码
if (score >= 90)
{
    Console.WriteLine("成绩优秀，继续保持！");
}
else
{
    Console.WriteLine("再接再厉。");
}

// ===== 3. 控制流：循环 =====
// for 三段式：初始条件；继续条件；每轮结束后做什么
Console.WriteLine("倒数 3 秒：");
for (int i = 3; i >= 1; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("出发！");
Console.WriteLine();

// ===== 4. 方法（函数）=====
// 把一段逻辑打包，起个名字，就能反复调用
// 格式：返回类型 方法名(参数类型 参数名) { ... return ...; }
int Add(int a, int b)
{
    return a + b;
}

int total = Add(7, 5);
Console.WriteLine($"7 + 5 = {total}");
Console.WriteLine();

// ===== 5. 类与对象 =====
// 类 = 图纸，对象 = 按图纸造出来的实例
Dog myDog = new Dog("小黑");
myDog.Speak();

Console.WriteLine();
Console.WriteLine("========== 以上是第一课复习，下面进入第二课 ==========");
Lesson2.Run();

// 暂停在这里，等你按回车再退出窗口。
// 这样即使双击 exe 启动，窗口也不会一闪而过。
Console.WriteLine();
Console.Write("按回车键退出...");
Console.ReadLine();

// 在顶层语句文件里，类的定义必须放在所有语句的后面
class Dog
{
    public string Name { get; set; }

    public Dog(string name)
    {
        Name = name;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name}：汪汪！");
    }
}
