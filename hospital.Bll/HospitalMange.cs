using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using hospital.DTo;

namespace hospital.Bll
{
    public class HospitalMange : IBll.IHospitalMange
    {
        private readonly IDAl.IHospitalServer hospital;

        public HospitalMange(IDAl.IHospitalServer server)
        {
            hospital = server;
        }
        public async Task Add(string name, string address, string yuan, string ji, string Phone)
        {
            await hospital.Add(new Models.Hospital()
                {Name = name, Address = address, YuName = yuan, Rank = ji, Phone = Phone});
        }

        public Task<List<Hospital>> All()
        {
            throw new NotImplementedException();
        }

        public async Task Rome(int Id)
        {
            await hospital.Rome(new Models.Hospital() {Id = Id});
        }

        public async Task Update(int Id, string name, string address, string yuan, string ji, string Phone)
        {
            await hospital.Update(new Models.Hospital() { Id = Id, Name = name, Address = address, YuName = yuan, Rank = ji, Phone = Phone });
        }
    }
}
