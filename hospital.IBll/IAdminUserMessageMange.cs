using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hospital.IBll
{
  public  interface IAdminUserMessageMange
  {
      Task Add(string name,int age,string sex,int AdminUserID);
      Task Rome(int Id);
      Task Update(int Id, string name, int age, string sex, int AdminUserId);
      Task<List<DTo.AdministratorUser>> All();
  }
}
