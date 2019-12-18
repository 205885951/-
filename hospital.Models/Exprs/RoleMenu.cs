using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 角色分配菜单
    /// </summary>
   public class RoleMenu:BaseModels
    {
        public int MenuId { get; set; }
       
        public int RoleId { get; set; }
    }
}
