using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.DTo
{
 public   class Nurse
    {
        /// <summary>
        /// 医院Id
        /// </summary>
        public int HospitalId { get; set; }
        public  string HospName { get; set; }
        /// <summary>
        /// 职位Id
        /// </summary>
        public int PositionId { get; set; }

        public string PositName
        {
            get;
            set;
        }

        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public DateTime Chusheng { get; set; }
        public string Address { get; set; }
        /// <summary>
        /// 固定电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 移动电话
        /// </summary>
        public string MovePhone { get; set; }

    }
}
