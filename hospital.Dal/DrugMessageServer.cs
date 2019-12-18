using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class DrugMessageServer:BaseServer<Models.Exprs.DrugMessage>,IDAl.IDrugMessageServer
    {
        public DrugMessageServer():base(new DbContext())
        {
            
        }
    }
}
