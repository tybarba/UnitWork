using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit14Lab
{
    public class Person
    {
        private static string defaultDomainName = "my.ntu.ac.uk";

        private string givenName;
        private string familyName;
        private string phoneNumber;
        private string emailAddress;

        public Person(string givenName, string familyName, string phoneNumber)
        {
            this.setName(givenName, familyName);
            this.setPhoneNumber(phoneNumber);
            this.emailAddress = $"{this.givenName}.{this.familyName}{DateTime.Now.Year}@{defaultDomainName}";
        }
        public Person(string givenName, string familyName) : this (givenName, familyName, "8888888888")
        {
            
        }

        public static void setDefaultDomainName(string newDefaultDomainName)
        {
            //string errorMessage = "";
            if (string.IsNullOrEmpty(newDefaultDomainName))
            {
                throw new Exception("New default domain name cannot be null or empty");
            }
            if (string.IsNullOrWhiteSpace(newDefaultDomainName))
            {
                throw new Exception("New default domain name cannot be null or whitespace");
            }
            for (int i = 0; i<newDefaultDomainName.Length; i++)
            {
                if (newDefaultDomainName[i] == ' ')
                {
                    throw new Exception($"New default domain name cannot contain spaces. Error located at char[{i}]");
                }
            }
            defaultDomainName = newDefaultDomainName;
        }

        public string getEmailAddress()
        {
            return this.emailAddress;
        }

        public void setPhoneNumber(string newPhoneNumber)
        {
            for (int i = 0; i < newPhoneNumber.Length; ++i)
            {
                if (!Char.IsDigit(newPhoneNumber[i]))
                {
                    throw new ArgumentException("Phone numbers may only contain digits.");
                }
            }
            this.phoneNumber = newPhoneNumber;
        }

        public void setFamilyName(string newFamilyName)
        {
            if (string.IsNullOrEmpty(newFamilyName))
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrWhiteSpace(newFamilyName))
            {
                throw new ArgumentException("Family names cannot be white space.");
            }
            this.familyName = newFamilyName;
        }

        public void setGivenName(string newGivenName)
        {
            if (string.IsNullOrEmpty(newGivenName))
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrWhiteSpace(newGivenName))
            {
                throw new ArgumentException("Given names cannot be white space.");
            }
            this.givenName = newGivenName;
        }

        public void setName(string newGivenName, string newFamilyName)
        {
            this.setGivenName(newGivenName);
            this.setFamilyName(newFamilyName);
        }

        public string getName()
        {
            return $"{this.givenName} {this.familyName}";
        }

        public bool hasPhoneNumber()
        {
            return this.phoneNumber != null;
        }

        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }
    }
}
