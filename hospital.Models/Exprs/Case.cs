using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 病例
    /// </summary>
  public  class Case:BaseModels
    {
        public  string Name { get; set; }
        public  int DoctorId { get; set; }
        /// <summary>
        /// 病例
        /// </summary>
        public  string BinContext { get; set; }
    }
}
