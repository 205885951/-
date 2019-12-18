using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class CaseServer:BaseServer<Models.Case>,IDAl.ICaseServer
    {
        public CaseServer():base(new DbContext())
        {
            
        }
    }
}
