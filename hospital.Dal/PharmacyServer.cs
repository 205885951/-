using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class PharmacyServer:BaseServer<Models.Exprs.Pharmacy>,IDAl.IPharmacyServer
    {
        public PharmacyServer():base(new DbContext())
        {
            
        }
    }
}
