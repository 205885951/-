using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
  public  class BreakageServer:BaseServer<Models.Exprs.Breakage>,IDAl.IBreakageServer
    {
        public BreakageServer():base(new DbContext())
        {
                
        }
    }
}
