using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class NurseServer:BaseServer<Models.Nurse>,IDAl.INurseServer
    {
        public NurseServer():base(new DbContext())
        {
            
        }
    }
}
