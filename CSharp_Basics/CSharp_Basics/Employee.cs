using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    public class Employee
    {
        public string NameOfPerson { get; } //moze byc tylko get, wtedy juz wcale nie ma
        public uint IdOfEmployee { get; }
        public Locations Location { get; }

        public Employee(string name, uint iDOfEmployee, string department, string interestedIn)
        {

            this.NameOfPerson = name;
            this.IdOfEmployee = iDOfEmployee;
            Locations temp;
            Enum.TryParse(department, out temp);
            Location = temp;
            this.InterestedIn = interestedIn;
        }
        public Employee(string name, uint iDOfEmployee, Locations department, string interestedIn)
        {

            this.NameOfPerson = name;
            this.IdOfEmployee = iDOfEmployee;
            this.Location = department;
            this.InterestedIn = interestedIn;

            ValidateID(iDOfEmployee, department);
        }

        private void ValidateID(uint iDOfEmployee, Locations department)
        {
           if(iDOfEmployee<10000||iDOfEmployee>99999)
            {
                throw new ArgumentOutOfRangeException("Badge should have 5 digits");
            }

        }

        protected string InterestedIn { get; }

        public string Location2String()
        {
            return Location.ToString();
        }
        //public string NameOfPerson { get; private set;} //moze byc tylko get, wtedy juz wcale nie ma
        //public uint IdOfEmployee { get; private set; }
        //public string Department { get; private set; }
       
        public bool IsNorthOfWarschau()
        {
            if(Location==Locations.koszalin|| Location == Locations.szczecin)
            {
                return true;
            }

            return false;            
        }

       
    }
}
