
using System;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    public class EmployeeTestsa
    {
        [Test]
        public void aaa()
        {
            Console.WriteLine("wtf");
        }
        [Test]
        public void Employee_Creation_FiledProperlyField()
        {
            var employee = new Employee("Emka", 666, "Koszalin");
            var employee2 = new Employee("Lka", 669, "Koszalin");
            var employee3 = new Employee("Ska", 668, "Koszalin");
            var employee4 = new Employee("Xlka", 664, "Wroclaw");

            Assert.That(employee.BadgeID, Is.EqualTo(666));
            Assert.That(employee.LocationString, Is.EqualTo("Koszalin"));
            Assert.That(employee.Name, Is.EqualTo("Emka"));

            Assert.That(employee2.BadgeID, Is.EqualTo(669));
            Assert.That(employee2.LocationString, Is.EqualTo("Koszalin"));
            Assert.That(employee2.Name, Is.EqualTo("Lka"));

            Assert.That(employee3.BadgeID, Is.EqualTo(668));
            Assert.That(employee3.LocationString, Is.EqualTo("Koszalin"));
            Assert.That(employee3.Name, Is.EqualTo("Ska"));

            Assert.That(employee4.BadgeID, Is.EqualTo(664));
            Assert.That(employee4.LocationString, Is.EqualTo("Wroc"));
            Assert.That(employee4.Name, Is.EqualTo("Xlka"));
        }

        [Test]
        public void EmployeeIT_CreationUsingEnum_FiledProperlyField()
        {
            var employee = new ItEmployee("Emka", 666, Locations.Koszalin, "C#");


            Assert.That(employee.BadgeID, Is.EqualTo(666));
            Assert.That(employee.LocationString, Is.EqualTo("Koszalin"));
            Assert.That(employee.Name, Is.EqualTo("Emka"));

        }

        [TestCase(Locations.Szczecin, true)]
        [TestCase(Locations.Koszalin, true)]
        [TestCase(Locations.Wroclaw, false)]
        [TestCase(Locations.Krakow, true)]
        [TestCase(Locations.ZielonaGora, false)]
        public void ItEmployee_IsNorthOfWarsow(Locations loc, bool result)
        {
            var employee = new ItEmployee("Emka", 666, loc, "C#");

            Assert.That(employee.IsNorthOfWarsaw, Is.EqualTo(result));




        }
        //północ
        /*id 
        1-5 - 5 cyfr
        południe
        6-9 - 5 cyfr

        throw new ArgumentOutOfRangeException();*/
        [Test]
        public void Employe_IdIsOutOfRange_ThrowsArgrumentOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new ItEmployee("Emka", 666, Locations.Koszalin, "C#")
                );
        }

        [TestCase(Locations.Koszalin,11111)]
        [TestCase(Locations.ZielonaGora,66666)]
        public void Employe_IDisInWrongRange_ThrowsArgrumentOutOfRange(Locations loc, int badge)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new Employee("Emka", badge, loc)
            );
        }
    }
}
