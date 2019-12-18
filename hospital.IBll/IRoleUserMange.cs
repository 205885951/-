using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hospital.IBll
{
   public interface IRoleUserMange
   {
       Task Add(string name,int roleId,int AdminUserId);
       Task Rome(int ID);
       Task Update(int Id, string Name, int roleId, int AdminUserId);
       Task<List<DTo.RoleUser>> All();
   }
}
