using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.DTo
{
   public class Account
    {
        public  int Id { get; set; }
       
        /// <summary>
        /// 就诊卡ID
        /// </summary>
        public  int PatientBlockId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        public  long Money { get; set; }
    }
}
