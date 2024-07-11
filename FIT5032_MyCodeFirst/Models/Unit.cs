using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_MyCodeFirst.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // 外键
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}