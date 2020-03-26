using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientProyect;

namespace PatientProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient.addDisorder(1);
            Patient.addDisorder(8);

            Console.WriteLine(Patient.hasDisorder(16));
            for (int i = 0; i < Patient.Disorders.Count; i++)
            {
                Console.WriteLine(Patient.Disorders[i]);
            }

            Console.WriteLine(Patient.isHealthy());

            Patient.Estado();


            Console.ReadKey();
        }
    }
}
