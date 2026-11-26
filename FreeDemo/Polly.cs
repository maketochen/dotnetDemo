using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FreeDemo
{
    public class PollyTest
    {
        

    }
    // 模拟数据模型 
    public record UserDto
    {
        public int Id { get; init; }
        public string Name { get; init; } = "";
        public string Email { get; init; } = "";
        public string Payload { get; init; } = "";
    }
}
