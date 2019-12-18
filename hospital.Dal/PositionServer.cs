using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Dal
{
   public class PositionServer:BaseServer<Models.Position>,IDAl.IPositionServer
    {
        public PositionServer():base(new Models.DbContext())
        {
            
        }
    }
}
