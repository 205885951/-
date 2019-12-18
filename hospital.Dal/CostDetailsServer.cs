using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class CostDetailsServer:BaseServer<Models.CostDetails>,IDAl.ICostDetailsServer
    {
        public CostDetailsServer():base(new DbContext())
        {
            
        }
    }
}
