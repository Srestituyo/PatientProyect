using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientProyect
{
    class Patient
    {
        public Patient(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public  List<string> Disorders = new List<string>();
        public static string[] enfermedades = {"Alcohol Addiction", "Anorexia", "Antisocial", "Anxiety", "Bipolar", "Bulimia", "Dependent (lack of self" +
                    "confidence" , "Depression", "Kleptomaniac", "Nicotine addiction", "Obsessive-compulsive", "Panic", "Paranoid", "Post-traumatic stress",
            "Programmer", "Tester",};

        public static  string DisorderGet(uint x)
        {
            for (int i = 0; i < enfermedades.Length; i++)
            {
                long shift = 1 << i;
                if ((x & shift) > 0)
                {
                    return enfermedades[i];
                }

            }
            return "";
        }
        public  bool hasDisorder(uint disorder)
        {
            string checkDisorder = DisorderGet(disorder);

            if (Disorders.Contains(checkDisorder))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public  bool addDisorder(uint x)
        {
            string newDisorder = DisorderGet(x);

            if (newDisorder == "")
            {
                return false;
            }

            else if (Disorders.Contains(newDisorder))
            {
                return false;
            }
            else
            {
                Disorders.Add(newDisorder);
                return true;
            }



        }

        public  bool isHealthy()
        {
            if (Disorders.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public  void Estado()
        {
            Console.WriteLine("{0} {1} tiene los siguientes desordenes:", Nombre, Apellido);

            for (int i = 0; i < Disorders.Count; i++)
            {
                Console.WriteLine($"{i}. {Disorders[i]}");
            }
        }

    }
}
    

