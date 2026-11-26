using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreeDemo
{

    [Table(Name = "user")] // 确保表名和数据库一致
    public class User
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public int Id { get; set; }

        [Column(StringLength = 50)]
        public required string Name { get; set; }

        public int Age { get; set; }
    }
}
