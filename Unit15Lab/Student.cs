using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit15Lab
{
    public class Student
    {
        private string GivenName;
        private string FamilyName;
        private string StudentNumber;
        private string Course;

        public Student(string givenName, string familyName, string studentNumber, string course)
        
        {
            // doesn't work because it's not a reference type?
            this.GivenName = givenName;
            this.FamilyName = familyName;
            this.StudentNumber = studentNumber;
            this.Course = course;
        }

        public string GetName()
        {
            return this.GivenName + " " + this.FamilyName;
        }

        public string GetStudentNumber()
        {
            return this.StudentNumber;
        }

        public string GetCourse()
        {
            return this.Course;
        }

        private void CheckValidName(string name)
        {
            string errorMessage = "";
            if(name == "null")
            {
                errorMessage += "Error: name cannot be null.\n";
            }
            if(string.IsNullOrWhiteSpace(name))
            {
                errorMessage += "Error: name cannot be whitespace.\n";
            }
            if(name == "")
            {
                errorMessage += "Error: name cannot be empty.\n";
            }
            for(int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    errorMessage += $"Error: name cannot contain spaces. See name[{i}].\n";
                }
            }
            if(errorMessage != "")
            {
                throw new Exception(errorMessage);
            }
        }
    }
}
