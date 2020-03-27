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

            PatientList LinkedList = new PatientList();



            Patient p1 = new Patient("Fulano", "Mengano");


            p1.addDisorder(1);
            p1.addDisorder(8);

            Patient p2 = new Patient("Samuel", "García");

            p2.addDisorder(16);
            p2.addDisorder(4);


            LinkedList.Add(p1);
            LinkedList.Add(p2);

            Patient[] listaLinked = LinkedList.All();

          

            for (int i = 0; i < listaLinked.Length; i++)
            {
                Console.WriteLine(listaLinked[i].Nombre);
            }

            

            Console.WriteLine(p1.isHealthy());

            p1.Estado();

            p2.Estado();

            LinkedList.Remove(p1);

            Patient[] newlistaLinked = LinkedList.All();

            for (int i = 0; i < newlistaLinked.Length; i++)
            {
                Console.WriteLine(newlistaLinked[i].Nombre);
            }


            Console.ReadKey();


        }
    }
}
