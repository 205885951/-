using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hospital.IBll
{
  public  interface IAdministratorUserMange
  {
      Task Add(string account,string password);
      Task Rome(int Id);
      Task Update(string account,string password);
      Task<List<DTo.AdministratorUser>> All();

  }
}
