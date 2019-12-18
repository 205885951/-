using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models.Exprs
{
    /// <summary>
    /// 药品信息
    /// </summary>
   public class DrugMessage:BaseModels
    {
        /// <summary>
        /// 类型Id
        /// </summary>
        public  int DrugTypeId { get; set; }

        public  string Name { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public  string Unit { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public  string Specification { get; set; }
    }
}
