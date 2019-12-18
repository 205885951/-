using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class DoctorServer:BaseServer<Models.Doctor>,IDAl.IDoctorServer
    {
        public DoctorServer():base(new DbContext())
        {
            
        }
    }
}
