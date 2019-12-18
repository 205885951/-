using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hospital.IBll
{
   public interface IMenuMange
   {
       Task Add(string type,string url,int PrparentId);
       Task Rome(int Id);
       Task Update(int Id, string type, string url, int PrparentId);
       Task<List<DTo.Menu>> All();
   }
}
