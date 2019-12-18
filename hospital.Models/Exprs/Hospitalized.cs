using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 住院病人登记信息
    /// </summary>
    public class Hospitalized : BaseModels
    {
        /// <summary>
        /// 医院ID
        /// </summary>
        public int HospitalId { get; set; }
        /// <summary>
        /// 主治医师Id
        /// </summary>
        public int DoctorId { get; set; }
        /// <summary>
        /// 护士
        /// </summary>
        public int NurseId { get; set; }
        /// <summary>
        /// 病房Id
        /// </summary>
        public int HospitalID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        /// <summary>
        /// 出院日期
        /// </summary>
        public string Chu { get; set; }

        public string Address { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 担任人
        /// </summary>
        public string Dan { get; set; }
        /// <summary>
        /// 出院结论
        /// </summary>
        public string Lun { get; set; }
        /// <summary>
        /// 押金
        /// </summary>
        public long Money { get; set; }

    }
}
