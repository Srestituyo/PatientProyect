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

            Patient p1 = new Patient();

            p1.Nombre = "Fulano";
            p1.Apellido = "Mengano";


            p1.addDisorder(1);
            p1.addDisorder(8);

            Console.WriteLine(p1.hasDisorder(16));
            for (int i = 0; i < p1.Disorders.Count; i++)
            {
                Console.WriteLine(p1.Disorders[i]);
            }

            Console.WriteLine(p1.isHealthy());

            p1.Estado();


            Console.ReadKey();
        }
    }
}
