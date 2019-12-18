using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hospital.IBll
{
   public interface IPatientMange
   {
       Task Add(int HospitalId,int RegistrationId,int OfficeId,int DoctorId,string name,int age,string sex,int PatientBlockId);
       Task Rome(int Id);
       Task Update(int Id,int HospitalId,int RegistrationId,int OfficeId,int DoctorId,string name,int age,string sex,int PatientBlockId);
       Task<List<DTo.Patient>> All();
   }
}
