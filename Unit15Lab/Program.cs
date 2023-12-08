using Unit14Lab;
using Unit6Lab;

namespace Unit15Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GuessWordGame game = new GuessWordGame();
            game.PlayGame();
            //string[] personNames = { "Ada", "Charles", "Donald", "Alan", "Haskell", "Alonzo" };
            //File.WriteAllLines("people.txt", personNames);

            //string[] studentInfo = File.ReadAllLines("students.txt");
            //Student[] students = new Student[studentInfo.Length];
            //int index = 0;
            //foreach (var studentString in studentInfo)
            //{
            //    string[] studentData = studentString.Split(",");
            //    string[] name = studentData[0].Split(" ");
            //    string givenName = name[0];
            //    string familyName = name[1];
            //    string number = studentData[1];
            //    string course = studentData[2];
            //    students[index] = new Student(givenName, familyName, number, course);
            //    index++;
            //}
            //Console.WriteLine();

            //Console.WriteLine("Enter a course name: ");
            //string courseChoice = Console.ReadLine();
            //GetStudentsInDegree(courseChoice);


            //void GetStudentsInDegree(string course)
            //{
            //    for(int i = 0; i < students.Length; i++)
            //    {
            //        if (students[i].GetCourse() == course)
            //        {
            //            Console.WriteLine(students[i].GetName() + " " + students[i].GetStudentNumber());
            //        }
            //    }
            //}
        }

    }
}