using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models.Exprs
{
    /// <summary>
    /// 库存
    /// </summary>
  public  class Inventory:BaseModels
    {
        /// <summary>
        /// 医院Id
        /// </summary>
        public int HospitalID { get; set; }
        /// <summary>
        /// 药品Id
        /// </summary>
        public  int DrugMessageId { get; set; }
        /// <summary>
        /// 单位i
        /// </summary>
        public  string Dan { get; set; }
        /// <summary>
        /// 库存数量
        /// </summary>
        public  int Shu { get; set; }
        /// <summary>
        /// 报警数量
        /// </summary>
        public int Call { get; set; }

    }
}
