using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hospital.DTo;

namespace hospital.IBll
{
    public interface IUserMange
    {
        Task Add(string account,string password);
        Task Rome(int Id);
        Task Update(int Id,string password);
       Task<List<User>> All();
        Task<List<User>>AllWhere(string name);
        
    }
}
