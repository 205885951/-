using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class StorageServer:BaseServer<Models.Exprs.Storage>,IDAl.IStorageServer
    {
        public StorageServer():base(new DbContext())
        {
            
        }
    }
}
