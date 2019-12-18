using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class PrescriptionServer:BaseServer<Models.Prescription>,IDAl.IPrescriptionServer
    {
        public PrescriptionServer():base(new DbContext())
        {
            
        }
    }
}
