using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 医院表
    /// </summary>
    public class Hospital : BaseModels
    {
        public string Name { get; set; }
        public string Address { get; set; }
        /// <summary>
        /// 院长名字
        /// </summary>
        public string YuName { get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public string Rank { get; set; }
        public string Phone { get; set; }
    }
}
