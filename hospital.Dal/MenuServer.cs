using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class MenuServer:BaseServer<Models.Menu>,IDAl.IMenuServer
    {
        public MenuServer():base(new DbContext())
        {
            
        }
    }
}
