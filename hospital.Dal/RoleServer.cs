using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class RoleServer:BaseServer<Models.Role>,IDAl.IRoleServer
    {
        public RoleServer():base(new DbContext())
        {
            
        }
    }
}
