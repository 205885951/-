using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 检查收费项目表
    /// </summary>
    public class Cost:BaseModels
    {
        /// <summary>
        /// 做的什么检查
        /// </summary>
        public  string Mingchneg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  int PatientID { get; set; }
        public  string Name { get; set; }
        public  long Money { get; set; }
        public  string Biao { get; set; }
    }
}
