using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
  public  class PatientBlockServer:BaseServer<Models.PatientBlock>,IDAl.IPatientBlockServer
    {
        public PatientBlockServer():base(new DbContext())
        {
            
        }
    }
}
