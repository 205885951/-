using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using hospital.DTo;

namespace hospital.Bll
{
    public class PatientMange : IBll.IPatientMange
    {
        private readonly IDAl.IPatientServer Patient;

        public PatientMange(IDAl.IPatientServer server)
        {
            Patient = server;
        }
        public async Task Add(int HospitalId, int RegistrationId, int OfficeId, int DoctorId, string name, int age, string sex, int PatientBlockId)
        {
            await Patient.Add(new Models.Patient()
            {
                HospitalId = HospitalId, RegistrationId = RegistrationId, OfficeId = OfficeId, DoctorId = DoctorId,
                Name = name, Age = age, Sex = sex, PatientBlockId = PatientBlockId
            });
        }

        public Task<List<Patient>> All()
        {
            throw new NotImplementedException();
        }

        public async Task Rome(int Id)
        {
            await Patient.Rome(new Models.Patient() {Id = Id});
        }

        public async Task Update(int Id, int HospitalId, int RegistrationId, int OfficeId, int DoctorId, string name, int age, string sex, int PatientBlockId)
        {
            await Patient.Update(new Models.Patient()
            {
                Id = Id, HospitalId = HospitalId, RegistrationId = RegistrationId, OfficeId = OfficeId,
                DoctorId = DoctorId, Name = name, Age = age, Sex = sex, PatientBlockId = PatientBlockId
            });
        }
    }
}
