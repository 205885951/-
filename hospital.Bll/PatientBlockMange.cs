using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospital.DTo;

namespace hospital.Bll
{
    public class PatientBlockMange : IBll.IPatientBlockMange
    {
        private readonly IDAl.IPatientBlockServer Patient;

        public PatientBlockMange(IDAl.IPatientBlockServer server)
        {
            Patient = server;
        }
        public async Task Add( string Name)
        {
            await Patient.Add(new Models.PatientBlock() {Name = Name});
        }

        public async Task<List<PatientBlock>> All()
        {
           return await Task.Run(() =>
               {
                   return Patient.All().Select(m => new DTo.PatientBlock() {Id = m.Id, Name = m.Name, GuidId = m.Guid})
                       .ToList();
               });
        }

        public async Task Rome(int ID)
        {
            await Patient.Rome(new Models.PatientBlock() {Id = ID});
        }

        public async Task Update(int Id, string name)
        {
            await Patient.Update(new Models.PatientBlock() {Id = Id, Name = name});
        }
    }
}
