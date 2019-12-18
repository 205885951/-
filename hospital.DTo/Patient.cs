using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.DTo
{
   public class Patient
    {
        public  int ID { get; set; }
        public  int HospitalId { get; set; }
        public  string HospName { get; set; }
        public  int RegistrationId { get; set; }
        public  string RegiName { get; set; }
        public  int OfficeId { get; set; }
        public  string OffName { get; set; }
        public  int DoctorId { get; set; }
        public  string DoctoName { get; set; }
        public  string Name { get; set; }
        public int Age { get; set; }
        public  string Sex { get; set; }
        public  int PatientBlockId { get; set; }
    }
}
