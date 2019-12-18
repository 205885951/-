using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hospital.IBll
{
  public  interface IPositionMange
  {
      Task Add(string name);
      Task Rome(int Id);
      Task Update(int Id, string name);
      Task<List<DTo.Position>> All();
  }
}
