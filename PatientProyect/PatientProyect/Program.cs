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





            patientList.Add(patient);
            patientList.Add(patient1);
            patientList.All();
            var contains = patientList.Contains(patient1);
            Console.WriteLine();
            Console.WriteLine($"Conatins patient {patient1.Apellido} : {contains}");
            patientList.Remove(patient);
            patientList.All();
            patientList.All();



            Console.ReadKey();
        }
    }
}
