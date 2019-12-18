using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hospital.IBll
{
   public interface IRoleMenuMange
   {
       Task Add(int RoleId, int MenID);
       Task Rome(int Id);
       Task Update(int Id, int RoleId, int MenID);
       Task<List<DTo.RoleMenu>> All();

   }
}
