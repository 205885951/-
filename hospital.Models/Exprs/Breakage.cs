using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models.Exprs
{
    /// <summary>
    /// 报损
    /// </summary>
  public  class Breakage:BaseModels
    {
        /// <summary>
        /// 医院Id
        /// </summary>
        public  int YIId { get; set; }
        /// <summary>
        /// 药品Id
        /// </summary>
        public  int DrugMessId { get; set; }
        /// <summary>
        /// 报损数量
        /// </summary>
        public  int Shu { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public  string Dan { get; set; }
        /// <summary>
        /// 医师ID
        /// </summary>
        public  int Yishi { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        public  int ShengHe { get; set; }

    }
}
