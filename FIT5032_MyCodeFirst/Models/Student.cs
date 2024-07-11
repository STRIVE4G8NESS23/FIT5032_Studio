using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace FIT5032_MyCodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // 导航属性
        public virtual ICollection<Unit> Units { get; set; }
    }
}