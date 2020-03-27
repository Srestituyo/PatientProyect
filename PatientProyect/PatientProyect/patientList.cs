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
                if (!Equals(currentNode.data, element))
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
            PatientListNode zero = new PatientListNode(new Patient("Vacio", "Vacio"));
            if (element == null || count == 0)
            {
                return false;
            }

            for (int x = 0; x < count; x++)
            {
                if (Equals(currentNode.data, element))
                {
                    node = zero;
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
                head = currentNode;
                count--;
                return true;
            }

            return false;
        }

        public Patient[] All()
        {
            Patient[] patients = new Patient[count];
            PatientListNode runner = head;
            int contador = 1;
            while (runner != null)
            {

                for (int x = 0; x < patients.Length; x++)
                {
                    patients[x] = runner.data;
                    runner = runner.next;
                   
                }

                Array.Reverse(patients);
                contador++;

            }
          
            return patients;
        }

    }
}
