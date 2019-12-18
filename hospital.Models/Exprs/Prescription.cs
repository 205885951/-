using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 开处方
    /// </summary>
   public class Prescription:BaseModels
    {
        public  int DoctorID { get; set; }
        /// <summary>
        /// 处方内容
        /// </summary>
        public  string Context { get; set; }
        /// <summary>
        /// 病例Id
        /// </summary>
        public  int CaseID { get; set; }
    }
}
