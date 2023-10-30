using Assignment1.UserException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class MedicalRecord :Patient

    {

        public int RecordId { get; set; }
        public double TreatmentCost { get; set; }
        public MedicalRecord(int patientId,string? patientName,int age,string? diagnosis,int recordId, double treatmentCost)
        {
            RecordId = recordId;
            TreatmentCost = treatmentCost;
            PatientName = patientName;
            Age = age;
            Diagnosis = diagnosis;
            PatientId = patientId;
        }
        List<MedicalRecord> MList { get; set; }=new List<MedicalRecord>();
        
        public void AddRecord(MedicalRecord medicalRecord)
        {
            bool PValue = string.IsNullOrEmpty(PatientName);
            bool DValue = string.IsNullOrEmpty(Diagnosis);

            if (!PValue && !DValue)
            {
                if (TreatmentCost > 0)
                {
                    MList.Add(medicalRecord);
                    Console.WriteLine("Medical Record Added");
                    Console.WriteLine("Patient Id : " + PatientId + " Patient Name :" + PatientName +
            " Age: " + Age + " Diagnosis: " + Diagnosis + " Record Id: " +
            RecordId + " Treatment Cost: " + TreatmentCost);
                }
                else
                {
                    throw new InvalidPatientDataException(CustomException.customMessageList[3]);
                }

            }
            else
            {
                throw new InvalidMedicalRecordException(CustomException.customMessageList[2]);
            }
        }

    }




        
    }



  
        