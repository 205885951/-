using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 前端用户
    /// </summary>
   public class User:BaseModels
    {
        public  string Account { get; set; }
        public  string Password { get; set; }

    }
}
