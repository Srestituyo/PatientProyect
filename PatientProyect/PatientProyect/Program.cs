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

            PatientLinkedList LinkedList = new PatientLinkedList();
            PatientArryaList ArrayList = new PatientArryaList();



            Patient p1 = new Patient("Fulano", "Mengano");


            p1.addDisorder(1);
            p1.addDisorder(8);

            Patient p2 = new Patient("Samuel", "García");

            p2.addDisorder(16);
            p2.addDisorder(4);

            //Linked List add()
            LinkedList.Add(p1);
            LinkedList.Add(p2);

            //ArrayList List add()
            ArrayList.Add(p1);
            ArrayList.Add(p2);



            Patient[] listaLinked = LinkedList.All();
            Object[] arrayList = ArrayList.All();

          

            for (int i = 0; i < listaLinked.Length; i++)
            {
                Console.WriteLine(listaLinked[i].Nombre);
            }  
            
            for (int i = 0; i < arrayList.Length; i++)
            {
                Console.WriteLine(arrayList[i]);
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
