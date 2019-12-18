using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 管理员用户
    /// </summary>
  public  class AdministratorUser:BaseModels
    {
        public  string Account { get; set; }
        public  string Password { get; set; }
    }
}
