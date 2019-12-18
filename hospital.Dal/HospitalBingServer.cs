using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
  public  class HospitalBingServer:BaseServer<Models.Exprs.HospitalBing>,IDAl.IHospitalBingServer
    {
        public HospitalBingServer():base(new DbContext())
        {
            
        }
    }
}
