using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hospital.IBll
{
   public interface IHospitalMange
   {
       Task Add(string name, string address, string yuan, string ji, string Phone);
       Task Rome(int Id);
       Task Update(int Id, string name, string address, string yuan, string ji, string Phone);
       Task<List<DTo.Hospital>> All();
   }
}
