namespace Unit13Lab
{
    class Person
    {
        public string givenName;
        public string familyName;
        public string phoneNumber;

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
            return this.phoneNumber == null;
        }

        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }
    }

    class Program
    {
        static void Main()
        {
            Person alan = new Person();

            alan.setName("Alan","Turing");
            alan.setPhoneNumber("0123456789");
            alan.setFamilyName("Turing");
            Console.WriteLine(alan.getName());


            if (alan.hasPhoneNumber())
            {
                Console.WriteLine(alan.getPhoneNumber());
            }


            Console.WriteLine(alan.phoneNumber);
        }
    }
}