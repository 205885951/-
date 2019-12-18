using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class CostServer:BaseServer<Models.Cost>,IDAl.ICostServer
    {
        public CostServer():base(new DbContext())
        {
            
        }
    }
}
