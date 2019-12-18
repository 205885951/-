using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class PriceServer:BaseServer<Models.Exprs.Price>,IDAl.IPriceServer
    {
        public PriceServer():base(new DbContext())
        {
            
        }
    }
}
