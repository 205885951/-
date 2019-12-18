using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using hospital.DTo;

namespace hospital.Bll
{
    public class RegistrationMange : IBll.IRegistrationMange
    {
        private readonly IDAl.IRegistrationServer Registration;

        public RegistrationMange(IDAl.IRegistrationServer server)
        {
            Registration = server;
        }
        public async Task Add(string name, long money)
        {
            await Registration.Add(new Models.Registration() {Name = name, Money = money});
        }

        public Task<List<Registration>> All()
        {
            throw new NotImplementedException();
        }

        public async Task Rome(int Id)
        {
            await Registration.Rome(new Models.Registration() {Id = Id});
        }

        public async Task Update(int Id, string name, long money)
        {
            await Registration.Update(new Models.Registration() {Id = Id, Name = name, Money = money});
        }
    }
}
