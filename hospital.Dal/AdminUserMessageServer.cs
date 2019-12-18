using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
  public  class AdminUserMessageServer:BaseServer<Models.Exprs.AdminUserMessage>,IDAl.IAdminUserMessageServer
    {
        public AdminUserMessageServer():base(new DbContext())
        {
                
        }
    }
}
