using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientProyect;
using PatientProyect.Interface;

namespace PatientProyect
{
    class Program
    {
        static void Main(string[] args)
        {

            PatientList patientList = new PatientList();
            Patient patient = new Patient("Sebastian", "Restituyo");

            patient.addDisorder(3);

            Patient patient1 = new Patient("Rafel", "marte");

            patient1.addDisorder(8);


  

            //Adding patient
            patientList.Add(patient);
            patientList.Add(patient1);

            //View All Patient
            patientList.All();

            //Search for patient
            var contains = patientList.Contains(patient1);

            //Remove Patient
            Console.WriteLine();
            Console.WriteLine($"Conatins patient {patient1.Apellido} : {contains}");
            patientList.Remove(patient);
            patientList.All();
       
           


            Console.ReadKey();
        }
    }
}
