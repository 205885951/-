using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospital.DTo;

namespace hospital.Bll
{
    public class AdministratorUserMange : IBll.IAdministratorUserMange
    {
        private readonly IDAl.IAdministratorUserServer User;

        public AdministratorUserMange(IDAl.IAdministratorUserServer server)
        {
            User = server;
        }
        public async Task Add(string account, string password)
        {
            await User.Add(new Models.AdministratorUser() {Account = account, Password = password});
        }

        public async Task<List<AdministratorUser>> All()
        {
          return  await Task.Run(() =>
                {
                   return User.All().Select(m => new DTo.AdministratorUser()
                        {Id = m.Id, account = m.Account, password = m.Password, DateTimes = m.DateTimes}).ToList();
                });
        }

        public async Task Rome(int Id)
        {
            await User.Rome(new Models.AdministratorUser() {Id = Id});
        }

        public async Task Update(string account, string password)
        {
            await User.Update(new Models.AdministratorUser() {Account = account, Password = password});
        }
    }
}
