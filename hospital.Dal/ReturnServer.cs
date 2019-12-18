using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
  public  class ReturnServer:BaseServer<Models.Exprs.Return>,IDAl.IReturnServer
    {
        public ReturnServer():base(new DbContext())
        {
            
        }
    }
}
