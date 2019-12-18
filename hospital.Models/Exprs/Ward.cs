using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 病房
    /// </summary>
  public  class Ward:BaseModels
    {
        /// <summary>
        /// 医院Id
        /// </summary>
        public int HospitalId { get; set; }
        /// <summary>
        /// 科室Id
        /// </summary>
        public  int OfficeID { get; set; }
        /// <summary>
        /// 病房病床数
        /// </summary>
        public int Chuang { get; set; }
        /// <summary>
        /// 剩余病房数
        /// </summary>
        public int Sheng { get; set; }
        /// <summary>
        /// 价位
        /// </summary>
        public long Price { get; set; }
    }
}
