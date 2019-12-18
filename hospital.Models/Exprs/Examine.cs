using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 检查项目
    /// </summary>
   public class Examine:BaseModels
    {
        /// <summary>
        /// 检查医生Id
        /// </summary>
        public  int DoctorID { get; set; }
        /// <summary>
        /// 时间安排
        /// </summary>
        public string An { get; set; }

        /// <summary>
        /// 检查类型Id
        /// </summary>
        public  int ExamineTyId { get; set; }
        /// <summary>
        /// 检查内容
        /// </summary>
        public string Context { get; set; }
        /// <summary>
        /// 检查分析
        /// </summary>
        public string Fenxi { get; set; }
        /// <summary>
        /// 检查结果
        /// </summary>
        public string Jie { get; set; }

        /// <summary>
        /// 病例Id
        /// </summary>
        public  int CaseId { get; set; }
    }
}
