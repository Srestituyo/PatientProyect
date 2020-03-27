using PatientProyect.Interface;
using PatientProyect.Models;
using System;

namespace PatientProyect
{
    class PatientList: IPatientList
    {
         List list = new List();

        public int PositiveIntergerOrZero(int num) 
        {
            //Number validation
            return num;
        } 
        
        public Boolean Add(string name, string lastName) 
        {
            //Add patient 
            return true;
        }

        public Boolean Contains(string name, string lastName) 
        {
            //Get patient
            return true;
        }
        
        public Boolean Remove(string name, string lastName) 
        {
            //Remove patient
            return true;
        }

        public string[] All () 
        {
            //Get all patient
            string[] array = new string[] { "Hello im patient" };
            return array;
        }
    }
}
