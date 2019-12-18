using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class SupplierServer:BaseServer<Models.Exprs.Supplier>,IDAl.ISupplierServer
   {
        public SupplierServer():base(new DbContext())
        {
            
        }
    }
}
