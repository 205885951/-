using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class OfficeServer:BaseServer<Models.Office>,IDAl.IOfficeServer
    {
        public OfficeServer():base(new DbContext())
        {
            
        }
    }
}
