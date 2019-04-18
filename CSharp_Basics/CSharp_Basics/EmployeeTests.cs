using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void Employee_Creation_FieldProperlyFilled()
        {
            var employee = new Employee("Emilia", 661, "koszalin", "dogs");
            var employee1 = new Employee("Aleksandra", 662, "wroclaw", "dogs");
            var employee2 = new Employee("Anna", 663, "koszalin", "dogs");


            Assert.Multiple(() =>
            {
                Assert.That(employee.IdOfEmployee, Is.EqualTo(661));
                Assert.That(employee.NameOfPerson, Is.EqualTo("Emilia"));
                Assert.That(employee.Location2String, Is.EqualTo("koszalin"));


                Assert.That(employee1.IdOfEmployee, Is.EqualTo(662));
                Assert.That(employee1.NameOfPerson, Is.EqualTo("Aleksandra"));
                Assert.That(employee1.Location2String, Is.EqualTo("wroclaw"));

                Assert.That(employee2.IdOfEmployee, Is.EqualTo(663));
                Assert.That(employee2.NameOfPerson, Is.EqualTo("Anna"));
                Assert.That(employee2.Location2String, Is.EqualTo("koszalin"));
            });
        }
        [Test]
        public void EmployeeInIT_CreationUsingEnums_FieldProperlyFilled()
        {
            var employee3 = new EmployeeInIT("Paprykarz", 666, Locations.szczecin, "C#");

            Assert.Multiple(() => {

                Assert.That(employee3.IdOfEmployee, Is.EqualTo(666));
                Assert.That(employee3.NameOfPerson, Is.EqualTo("Paprykarz"));
                Assert.That(employee3.Location2String, Is.EqualTo("szczecin"));
                Assert.That(employee3.ProgramingLanguage, Is.EqualTo("C#"));
            });

        }

        [TestCase(Locations.krakow, false)]
        [TestCase(Locations.szczecin, true)]
        [TestCase(Locations.koszalin, true)]
        public void CheckIsNorthOfWarschau(Locations loc, bool result)
        {
            var emplyee = new EmployeeInIT("em", 333, loc, "C#");

            Assert.That(emplyee.IsNorthOfWarschau(), Is.EqualTo(result));

        }

        /// polnoc ma miec id pieciocyfrowe i zaczynac sie od 1-5
        /// poludnie ma miec id pieciocyfrowe ale zaczynac sie 6-9
        /// 

        [TestCase(Locations.koszalin, 123)]
        public void CheckIfBadgeHas5Digits(Locations loc, uint IdNumber)
        {

            Assert.Throws<ArgumentOutOfRangeException>(
                () => new Employee("emma", IdNumber, loc, "dogs"));
        }


        //test for throwing an error
        [Test]
        public void TrhowError()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                ()=> new EmployeeInIT("emma",333,"koszalin","C#"));
        }

    }
}
