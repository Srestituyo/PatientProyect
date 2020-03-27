using System;
using System.Collections;
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

    //LinkedList Patient
    class PatientLinkedList : IPatientLinkedList<Patient>
    {
        int count;
        PatientListNode head;

        public PatientLinkedList()
        {
            head = null;
            count = 0;
        }

        public void Size(int num)
        {
            PositiveIntergerOrZero(num);
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

        public Patient[] All()
        {
            Patient[] patientArray = new Patient[count];
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
                    patientArray[x] = runner.data;
                }


                runner = runner.next;
                contador++;
                for (int z = 0; z <= patientArray.Length - 1; z++)
                {

                    Console.WriteLine(patientArray[z]);
                }

            }
            return patientArray;
        }


        private int value;
        public void PositiveIntergerOrZero(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(" ---ERORR --- El número debe de ser mayor o igual que 0....");
            }
            else
            {
                this.value = value;
            }
        }
    }

    //ArrayList Patient
    class PatientArryaList : IPatientLinkedList<Patient>
    {
        ArrayList PatientArrayList = new ArrayList();

        public void Size(int num)
        {
            PositiveIntergerOrZero(num);
        }

        public bool Add(Patient element)
        {
            if (element != null)
            {
                if (PatientArrayList.Count != 0)
                {
                    var containsList = PatientArrayList.Contains(element);

                    if (containsList == true)
                    {
                        return false;
                    }
                    else
                    {
                        PatientArrayList.Add(element);
                        return true;
                    }
                }
            }

            return false;
        }

        public bool Contains(Patient element)
        {
            var containList = PatientArrayList.Contains(element);

            if (containList == true)
            {
                return true;
            }

            return false;
        }

        public bool Remove(Patient element)
        {
            var containsList = PatientArrayList.Contains(element);

            if (containsList == true)
            {
                PatientArrayList.Remove(element);
                return true;
            }

            return false;
        }

        public Object[] All()
        {
            object[] patient = PatientArrayList.ToArray();

            return patient;
        }


        private int value;
        public void PositiveIntergerOrZero(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(" ---ERORR --- El número debe de ser mayor o igual que 0....");
            }
            else
            {
                this.value = value;
            }
        }
    }
}
