using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class InventoryServer:BaseServer<Models.Exprs.Inventory>,IDAl.IInventoryServer
    {
        public InventoryServer():base(new DbContext())
        {
            
        }
    }
}
