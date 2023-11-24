using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit12Lab
{
    public class Person
    {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string givenName, string familyName, string phoneNumber)
        {
            GivenName = givenName;
            FamilyName = familyName;
            PhoneNumber = phoneNumber;
        }

    }
}
