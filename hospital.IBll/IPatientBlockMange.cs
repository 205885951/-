using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hospital.IBll
{
  public  interface IPatientBlockMange
  {
      Task Add(string Name);
      Task Rome(int ID);
      Task Update(int Id,string name);
      Task<List<DTo.PatientBlock>> All();
  }
}
