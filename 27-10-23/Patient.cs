using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Assignment1.UserException;

namespace Assignment1
{
    internal class Patient
    {
        public Patient(int patientId, string? patientName,
              int age, string? diagnosis)
        {
            PatientId = patientId;
            PatientName = patientName;
            Age = age;
            Diagnosis = diagnosis;
        }

        public int PatientId { get; set; }
        public string? PatientName { get; set; }
        public int Age { get; set; }
        public string? Diagnosis { get; set; }
        
        List<Patient> Patients { get; set; } = new List<Patient>();

        public void AddPatient(Patient patient)
        {
            if (patient.Age >= 0 && patient.Age <= 120)
            {

                Console.WriteLine("Patient Added");
                Patients.Add(patient);
                Console.WriteLine("Patient Id : " + patient.PatientId + " Patient Name :" + patient.PatientName +
                " Age: " + patient.Age + " Diagnosis: " + patient.Diagnosis);


            }
            else
            {
                throw new AgeException(CustomException.customMessageList[1]);  
            }

        }
    }
}