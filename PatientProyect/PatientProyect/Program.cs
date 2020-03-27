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
            string opción, método, acciones;


            do
            {
                Console.Write("-----------------------------------------");
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1) - Ver el tamaño de la lista");
                Console.WriteLine("2) - Agregar paciente");
                Console.WriteLine("3) - Ver la condición del paciente");
                Console.WriteLine("4) - Remover paciete");
                Console.WriteLine("5) - Ver todos los pacientes");
                Console.Write("-----------------------------------------");
                opción = Console.ReadLine();
                Console.Clear();

                switch (opción)
                {
                    case "1":
                        {

                        }
                        break;

                    case "2":
                        {

                        }
                        break;

                    case "3":
                        {

                        }
                        break;

                    case "4":
                        {

                        }
                        break;

                    case "5":
                        {

                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Seleccione una opción válida...");
                        }
                        break;
                }
                do
                {
                    Console.Write("¿Desea seguir? Sino desea seguir presione n");
                    acciones = Console.ReadLine().ToLower();
                } while (acciones != "n" && acciones != "s" && acciones != "si" && acciones != "no");
                Console.Clear();

            } while (true | acciones == "s" | acciones == "si");


            

            
            Patient p1 = new Patient("Fulano", "Mengano");


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
