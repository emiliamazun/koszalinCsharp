using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    public class Employee
    {
        public string Name { get; }
        public int BadgeID { get; }
        public Locations Location { get; }

        public Employee(string name, int badgeId, string location)
        {

            this.Name = name;
            this.BadgeID = badgeId;
            Locations temp;
            Enum.TryParse(location, out temp);

            Location = temp;
            ValidateBadgeNumber();
        }

        public Employee(string name, int badgeId, Locations location)
        {

            this.Name = name;
            this.BadgeID = badgeId;
            this.Location = location;
            ValidateBadgeNumber();
        }

        private void ValidateBadgeNumber()
        {
            if(BadgeID < 10000 || BadgeID > 99999)
            {
                throw new ArgumentOutOfRangeException("Badge should have 5 digits");
            }

            if (IsNorthOfWarsaw() && BadgeID >= 60000)
            {
                return;
            }

            if (!IsNorthOfWarsaw() && BadgeID < 60000)
            {
                return;
            }
            throw new ArgumentOutOfRangeException("Bagde is from wrong region");
        }

        public string LocationString()
        {
            return Location.ToString();
        }

        public bool IsNorthOfWarsaw()
        {
            if (Location == Locations.Koszalin || Location == Locations.Szczecin)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}