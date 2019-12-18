using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
    public class UserServer : BaseServer<Models.User>,IDAl.IUserServer
    {
        public UserServer() : base(new DbContext())
        {

        }
    }
}
