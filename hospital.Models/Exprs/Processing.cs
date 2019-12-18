using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 医生处理方案
    /// </summary>
   public class Processing:BaseModels
    {
        public  int DoctorID { get; set; }
        /// <summary>
        /// 处理方案
        /// </summary>
        public  string Context { get; set; }
    }
}
