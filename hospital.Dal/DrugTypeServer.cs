using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class DrugTypeServer:BaseServer<Models.Exprs.DrugType>,IDAl.IDrugTypeServer
    {
        public DrugTypeServer():base(new DbContext())
        {
            
        }

    }
}
