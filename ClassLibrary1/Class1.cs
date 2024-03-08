namespace ClassLibrary1
{
    public class Employee
    {
        /* EmpID, EmpName, SalaryPerHour, NoOfWorkingHours and NetSalary. */
        public int empId;
        public string empName;
        public double salaryPerHour;
        public int noOfWorkingHours;
        public double netSalary;

        public static string organizationName;
        public const string typeOfEmployee = "Contract Based";
        public readonly string departmentName = "Finance Department";



    }

    public class MedicalBot
    {
        public const string botName = "Bob";

        public static string GetBotName()
        {
            return botName;
        }

        public void PrescribeMedication(Patient patient)
        {

            string symptom = patient.GetSymptoms();
            string medicine = "";
            if (symptom == "headache")
            {
                medicine = "ibuprofen";
            }
            else if(symptom == "skin rashes")
            {
                medicine = "diphenhydramine";
            }
            else if(symptom == "dizziness")
            {
                if(patient.GetMedicalHistory() == "diabetes")
                {
                    medicine = "metformin";
                }
                else
                {
                    medicine = "dimenhydrinate";
                }
            }

            string dosage = GetDosage();

            patient.SetPrescription(medicine + " " + dosage);

            string GetDosage()
            {




                if (medicine == "ibuprofen")
                {
                    if (patient.GetAge() < 18)
                        return "400 mg";
                    else
                        return "800 mg";
                }

                else if (medicine == "diphenhydramine")
                {
                    if (patient.GetAge() < 18)
                        return "50 mg";
                    else
                        return "300 mg";
                }

                else if (medicine == "dimenhydrinate")
                {
                    if (patient.GetAge() < 18)
                        return "50 mg";
                    else
                        return "400 mg";
                }
                else if (medicine == "metformin")
                    return "500 mg";

                return "";
            }
        }
    }

    public class Patient
    {

        private string name;
        private int age;
        private string gender;
        private string medicalHistory;
        private string symptomCode;
        private string prescription;

        
         public string GetName()
        {
            return name;
        }

        public bool SetName(string name, out string errorMessage)
        {
            if(name ==""||name.Length<2)
            {
                errorMessage = "Name is invalid";
                return false;
            }
            else
            {
                this.name = name;
                errorMessage = "";
                return true;
            }
        }
        
        public int GetAge()
        {
            return age;
        }

         public bool SetAge(int age, out string errorMessage)
        {
            if(age < 0 || age > 100)
            {
                errorMessage = "Invalid Age";
                return false;
            }
            else
            {
                errorMessage = "";
                this.age = age;
                return true;
            }
        }

        public string GetGender()
        {
            return gender;
        }
        
        public bool SetGender(string gender, out string errorMessage)
        {
            if(gender.ToLower() == "male" || gender.ToLower() == "female" || gender.ToLower()  == "other")
            {
                errorMessage = "";
                this.gender = gender.ToLower();
                return true;
            }
            else
            {
                errorMessage = "invalid gender";
                return false;
            }
        }

        public string GetMedicalHistory()
        {
            return medicalHistory;
        }

        public void SetMedicalHistory(string medicalHistory)
        {
            this.medicalHistory = medicalHistory;
        }

        public bool SetSymptomCode(string symptomCode, out string errorMessage)
        {
            if( symptomCode.ToLower() == "s1" || symptomCode.ToLower() == "s2" || symptomCode.ToLower() == "s3")
            {
                this.symptomCode = symptomCode.ToLower();
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "Invalid Symptom code";
                return false;
            }
        }


        public string GetSymptoms()
        {
            if (this.symptomCode == "s1")
                return "headache";
            else if (this.symptomCode == "s2")
                return "skin rashes";
            else if (this.symptomCode == "s3")
                return "dizziness";
            else
                return "Unknown";
        }
       

        public string GetPrescription()
        {
            return prescription;
        }

        public void SetPrescription(string prescription)
        {
            this.prescription = prescription;
        }
    }
}
