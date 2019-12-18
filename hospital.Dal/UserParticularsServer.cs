using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class UserParticularsServer:BaseServer<Models.UserParticulars>,IDAl.IUserParticularsServer
    {
        public UserParticularsServer():base(new DbContext())
        {
            
        }
    }
}
