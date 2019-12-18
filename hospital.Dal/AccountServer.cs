using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class AccountServer:BaseServer<Models.Exprs.Account>,IDAl.IAccountServer
    {
        public AccountServer():base(new DbContext())
        {
            
        }
    }
}
