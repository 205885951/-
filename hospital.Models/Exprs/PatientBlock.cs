using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 就诊卡
    /// </summary>
  public  class PatientBlock:BaseModels
    {
        public Guid Guid = Guid.NewGuid();
        public  string Name { get; set; }

    }
}
