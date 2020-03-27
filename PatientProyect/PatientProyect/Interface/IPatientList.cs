
namespace PatientProyect.Interface
{
    class IPatientList
    {
        public interface IPatientLinkedList<Patient>
        {

            void Size(int num);

            bool Add(Patient element);

            bool Contains(Patient element);

            bool Remove(Patient element);

            Patient[] All();
        }
    }
}

