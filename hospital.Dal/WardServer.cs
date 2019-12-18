using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class WardServer:BaseServer<Models.Ward>,IDAl.IWardServer
    {
        public WardServer():base(new DbContext())
        {
            
        }
    }
}
