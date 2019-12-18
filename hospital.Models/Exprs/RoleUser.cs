using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 用户分配角色
    /// </summary>
   public class RoleUser:BaseModels
    {
        public  string Name { get; set; }
        public  int RoleId { get; set; }
        public  int AdministratorId { get; set; }
    }
}
