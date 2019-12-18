using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class RoleUserServer:BaseServer<Models.RoleUser>,IDAl.IRoleUserServer
    {
        public RoleUserServer():base(new DbContext())
        {
            
        }
    }
}
