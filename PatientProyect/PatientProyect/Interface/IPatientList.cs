
using System;

namespace PatientProyect.Interface
{
    interface IPatientList
    {
        int PositiveIntergerOrZero(int num);

        Boolean Add(string name, string lastName);

        Boolean Contains(string name, string lastName);

        Boolean Remove(string name, string lastName);

        string[] All();
    }
}
