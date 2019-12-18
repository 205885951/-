using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hospital.IBll
{
   public interface IRoleMange
   {
       Task Add(string Name);
       Task Rome(int Id);
       Task Update(int Id, string name);
       Task<List<DTo.Role>> All();
   }
}
