using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 科室
    /// </summary>
   public class Office:BaseModels
    {
        public  string Name { get; set; }
        public  int Number { get; set; }
    }
}
