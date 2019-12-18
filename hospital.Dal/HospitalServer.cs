using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class HospitalServer:BaseServer<Models.Hospital>,IDAl.IHospitalServer
    {
        public HospitalServer():base(new DbContext())
        {
            
        }
    }
}
