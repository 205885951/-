using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class ProcessingServer:BaseServer<Models.Processing>,IDAl.IProcessingServer
    {
        public ProcessingServer():base(new DbContext())
        {
            
        }
    }
}
