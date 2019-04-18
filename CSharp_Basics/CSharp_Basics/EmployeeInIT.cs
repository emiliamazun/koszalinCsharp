using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    public class EmployeeInIT : Employee
    {
        private static string interestedIn;

        public string ProgramingLanguage { get; }
        public EmployeeInIT(string name, uint iDOfEmployee, string department, string programmingLanguage) : base(name, iDOfEmployee, department, interestedIn)
        {
            this.ProgramingLanguage = programmingLanguage;
        }
        public EmployeeInIT(string name, uint iDOfEmployee, Locations department, string programmingLanguage) : base(name, iDOfEmployee, department, interestedIn)
        {
            this.ProgramingLanguage = programmingLanguage;
        }
    }
}
