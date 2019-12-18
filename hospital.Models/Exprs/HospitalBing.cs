using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models.Exprs
{
   public class HospitalBing:BaseModels
    {
        /// <summary>
        /// 病床代号
        /// </summary>
        public string Daihao { get; set; }
        /// <summary>
        /// 是否是占用状态
        /// </summary>
        public  bool IsOccupied { get; set; }

        /// <summary>
        /// 病房Id
        /// </summary>
        public  int WardId { get; set; }
    }
}
