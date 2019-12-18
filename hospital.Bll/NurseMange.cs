using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using hospital.DTo;

namespace hospital.Bll
{
    public class NurseMange : IBll.INurseMange
    {
        private readonly IDAl.INurseServer nurse;

        public NurseMange(IDAl.INurseServer server)
        {
            nurse = server;
        }
        public async Task Add(int hospitalID, int positID, int officeID, string name, string sex, int age, DateTime chu, string address, string gudian, string yidong)
        {
            await nurse.Add(new Models.Nurse(){});
        }

        public Task<List<Nurse>> All()
        {
            throw new NotImplementedException();
        }

        public Task Rome(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int ID, int hospitalID, int positID, int officeID, string name, string sex, int age, DateTime chu, string address, string gudian, string yidong)
        {
            throw new NotImplementedException();
        }
    }
}
