using System;
using System.Collections.Generic;
using System.Text;
using hospital.Models;

namespace hospital.Dal
{
   public class ExamineTypeServer:BaseServer<Models.ExamineType>,IDAl.IExamineTypeServer
    {
        public ExamineTypeServer():base(new DbContext())
        {
            
        }
    }
}
