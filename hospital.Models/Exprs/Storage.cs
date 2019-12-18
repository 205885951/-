using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models.Exprs
{
    /// <summary>
    /// 入库
    /// </summary>
   public class Storage:BaseModels
    {
        /// <summary>
        /// 药品信息
        /// </summary>
        public  int DrugMessId { get; set; }
        /// <summary>
        /// 进价价格
        /// </summary>
        public  long Money { get; set; }
        /// <summary>
        /// 药房Id
        /// </summary>
        public  int PharmacyId { get; set; }
        public  int Nuer { get; set; }
        /// <summary>
        /// 入库医师Id
        /// </summary>
        public int DoctId { get; set; }

        /// <summary>
        /// 供应商Id
        /// </summary>
        public  int SupplierId { get; set; }
    }
}
