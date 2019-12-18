using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 医生
    /// </summary>
  public  class Doctor:BaseModels
    {
        public  int PatientId { get; set; }
        public  int PositionId { get; set; }
        public  int OfficeID { get; set; }
        public  string Name { get; set; }
        public  string Sex { get; set; }
        public  int Age { get; set; }
        public  string Address { get; set; }
        public  string Phone { get; set; }
        public  string YiPhone { get; set; }
    }
}
