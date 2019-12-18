using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 挂号病人信息
    /// </summary>
   public class Patient:BaseModels
    {
        /// <summary>
        /// 医院Id
        /// </summary>
        public  int HospitalId { get; set; }
        /// <summary>
        /// 挂号类型Id
        /// </summary>
        public  int RegistrationId { get; set; }
        /// <summary>
        /// 科室类型Id
        /// </summary>
        public  int OfficeId { get; set; }
        /// <summary>
        /// 医师Id
        /// </summary>
        public  int DoctorId { get; set; }
        public  string Name { get; set; }
        public  int Age { get; set; }
        public  string Sex { get; set; }

        /// <summary>
        /// 就诊卡Id
        /// </summary>
        public  int PatientBlockId { get; set; }
    }
}
