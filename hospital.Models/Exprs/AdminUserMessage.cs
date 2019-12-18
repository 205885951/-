using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models.Exprs
{
    /// <summary>
    /// 管理员信息
    /// </summary>
  public  class AdminUserMessage:BaseModels
    {
        public  string Name { get; set; }
        public  int Age { get; set; }
        public  string Sex { get; set; }
        /// <summary>
        /// 管理员Id
        /// </summary>
        public  int AdministratorUser { get; set; }
    }
}
