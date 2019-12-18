using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class ExamineServer:BaseServer<Models.Examine>,IDAl.IExamineServer
    {
        public ExamineServer():base(new DbContext())
        {
            
        }
    }
}
