using System;
using System.Collections.Generic;
using static PatientProyect.Interface.IPatientList;

namespace PatientProyect
{
    class PatientListNode
    {
        public Patient data;
        public PatientListNode next;

        public PatientListNode(Patient element)
        {
            data = element;
            next = null;
        }
    }

    class PatientList
    {
        int count;
        PatientListNode head;

        public PatientList()
        {
            head = null;
            count = 0;
        }

        public bool Add(Patient element)
        {
            PatientListNode node = new PatientListNode(element);

            node.next = head;
            head = node;
            count++;

            return true;
        }

        public bool Contains(Patient element)
        {
            var currentNode = head;

            PatientListNode node = new PatientListNode(currentNode.data);
            if (element == null || count == 0)
            {
                return false;
            }

            for (int x = 0; x <= count; x++)
            {
                if (currentNode.data.Apellido == element.Apellido && currentNode.data.Nombre == element.Nombre)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Remove(Patient element)
        {

            var currentNode = head;

            PatientListNode node = new PatientListNode(currentNode.data);
            if (element == null || count == 0)
            {
                return false;
            }

            for (int x = 0; x <= count; x++)
            {
                if (!Equals(currentNode.data, element))
                {
                    node = currentNode;
                    node.next = currentNode.next;
                }
            }

            //Element was not found in the list
            if (Equals(currentNode, null))
            {
                return false;
            }

            if (currentNode == head)
            {
                head = currentNode.next;
                count--;
                return true;
            }

            return false;
        }

        public void All()
        {
            PatientListNode runner = head;
            int contador = 1;
            while (runner != null)
            {
                Console.WriteLine();
                Console.WriteLine("Paciente #- " + contador);
                Console.WriteLine();
                Console.WriteLine("Nombre: " + runner.data.Nombre);
                Console.WriteLine("Apellido: " + runner.data.Apellido);
                Console.Write("Disorders: ");

                for (int x = 0; x <= runner.data.Disorders.Count - 1; x++)
                {
                    Console.Write(runner.data.Disorders[x] + ", ");
                }

                runner = runner.next;
                contador++;
                Console.WriteLine();
            }
        }


    }
}
