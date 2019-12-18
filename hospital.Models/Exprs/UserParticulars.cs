using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 前端用户详情
    /// </summary>
   public class UserParticulars:BaseModels
    {
        public  int UserId { get; set; }
        public  string Name { get; set; }
        public  int Age { get; set; }
        public  string Address { get; set; }
    }
}
