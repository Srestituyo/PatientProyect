﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientProyect
{
    class Program
    {
        public static string nombre = "Fulano";
        public static string apellidos = "Mengano";
        public static List<string> Disorders = new List<string>();
        public static string[] enfermedades = {"Alcohol Addiction", "Anorexia", "Antisocial", "Anxiety", "Bipolar", "Bulimia", "Dependent (lack of self" +
                    "confidence" , "Depression", "Kleptomaniac", "Nicotine addiction", "Obsessive-compulsive", "Panic", "Paranoid", "Post-traumatic stress",
            "Programmer", "Tester",};

        static string DisorderGet(uint x)
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
        static bool hasDisorder(uint disorder)
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
        static bool addDisorder(uint x)
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

        static bool isHealthy()
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

        static void Estado()
        {
            Console.WriteLine("{0} {1} tiene los siguientes desordenes:", nombre, apellidos);

            for (int i = 0; i < Disorders.Count; i++)
            {
                Console.WriteLine($"{i}. {Disorders[i]}");
            }
        }
        static void Main(string[] args)
        {


            addDisorder(1);
            addDisorder(8);

            Console.WriteLine(hasDisorder(16));
            for (int i = 0; i < Disorders.Count; i++)
            {
                Console.WriteLine(Disorders[i]);
            }

            Console.WriteLine(isHealthy());

            Estado();


            Console.ReadKey();

        }
    }
}
