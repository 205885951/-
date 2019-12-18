using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hospital.IBll
{
   public interface IAccountMange
   {
       Task Add(int PatientBlockId,long Balance);
       Task Rome(int Id);
       Task Update(int Id,int PatientBlockId,long Balance);
       Task<List<DTo.Account>> All();

   }
}
