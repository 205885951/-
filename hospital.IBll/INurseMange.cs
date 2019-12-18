using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hospital.IBll
{
   public interface INurseMange
   {
       Task Add(int hospitalID,int positID,int officeID,string name,string sex,int age,DateTime chu,string address,string gudian,string yidong);
       Task Rome(int Id);

       Task Update(int ID, int hospitalID, int positID, int officeID, string name, string sex, int age, DateTime chu,
           string address, string gudian, string yidong);

       Task<List<DTo.Nurse>> All();
   }
}
