using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class RegistrationServer:BaseServer<Models.Registration>,IDAl.IRegistrationServer
    {
        public RegistrationServer():base(new DbContext())
        {
            
        }
    }
}
