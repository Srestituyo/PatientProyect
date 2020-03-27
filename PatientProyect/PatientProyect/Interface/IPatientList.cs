
namespace PatientProyect.Interface
{
    class IPatientList
    {
        public interface IPatientLinkedList<Patient>
        {

            int Size(int num);

            bool Add(Patient element);

            bool Contains(Patient element);

            bool Remove(Patient element);

            string[] All();
        }
    }
}

