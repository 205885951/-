using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class AdministratorUserServer:BaseServer<Models.AdministratorUser>,IDAl.IAdministratorUserServer
    {
        public AdministratorUserServer():base(new DbContext())
        {
                
        }
    }
}
