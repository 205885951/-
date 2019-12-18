using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class HospitalizedServer:BaseServer<Models.Hospitalized>,IDAl.IHospitalizedServer
    {
        public HospitalizedServer():base(new DbContext())
        {
            
        }
    }
}
