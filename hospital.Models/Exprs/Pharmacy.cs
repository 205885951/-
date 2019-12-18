using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models.Exprs
{
    /// <summary>
    /// 药房
    /// </summary>
   public class Pharmacy:BaseModels
    {
        public string Name { get; set; }
        /// <summary>
        /// 医院Id
        /// </summary>
        public  int HospitalID { get; set; }
        /// <summary>
        /// 药房管理医师Id
        /// </summary>
        public  int DoctorId { get; set; }
    }
}
