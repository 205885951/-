using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hospital.IBll
{
   public interface IRegistrationMange
   {
       Task Add(string name, long money);
       Task Rome(int Id);
       Task Update(int Id, string name, long money);
       Task<List<DTo.Registration>> All();
   }
}
