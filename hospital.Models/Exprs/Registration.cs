using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 挂号类型
    /// </summary>
   public class Registration:BaseModels
    {
        public  string Name { get; set; }
        public  long Money { get; set; }
    }
}
