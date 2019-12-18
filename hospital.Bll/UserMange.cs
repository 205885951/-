using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hospital.DTo;
using hospital.IBll;
using  SqlSugar;
namespace hospital.Bll
{
    public class UserMange : IUserMange
    {
        private readonly IDAl.IUserServer user;

        public UserMange(IDAl.IUserServer userServer)
        {
            user = userServer;
        }
        public async Task Add(string account, string password)
        {
           await user.Add(new Models.User() {Account = account, Password = password});
        }

        public async Task<List<User>> All()
        {
          return  await Task.Run(() =>
            {
                return user.All().Select(m => new DTo.User()
                    {Id = m.Id, Account = m.Account, Password = m.Password, DateTimes = m.DateTimes}).ToList();
            });
        }

        public async Task<List<User>> AllWhere(string account)
        {
          return  await Task.Run(() =>
            {
                return
                user.All().Select(m => new DTo.User()
                    {Id = m.Id, Account = m.Account, Password = m.Password, DateTimes = m.DateTimes}).Where(m=>m.Account==account).ToList();
            });
        }

        public async Task Rome(int Id)
        {
            await user.Rome(new Models.User() {Id = Id});
        }

        public async Task Update(int Id, string password)
        {
            await user.Update(new Models.User()
            {
                Id = Id, Password = password

            });
        }
    }
}
