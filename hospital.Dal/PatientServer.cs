using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class PatientServer:BaseServer<Models.Patient>,IDAl.IPatientServer
    {
        public PatientServer():base(new DbContext())
        {
            
        }
    }
}
