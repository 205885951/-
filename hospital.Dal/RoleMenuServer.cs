using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class RoleMenuServer:BaseServer<Models.RoleMenu>,IDAl.IRoleMenuServer
    {
        public RoleMenuServer():base(new DbContext())
        {
            
        }
    }
}
