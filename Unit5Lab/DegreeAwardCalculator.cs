using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit5Lab
{
    public class DegreeAwardCalculator
    {
        //whether they have passed the course;
        //their weighted mean;
        //their majority grade;
        //and, if they have passed, the degree classification they will be awarded.
        const double maxGrade = 16;
        double maxCredits = 0;
        double weightedMean = 0;
        double majorityGrade = 0;
        List<double> grades = new List<double>();
        List<double> gradesWeights = new List<double>();
        int numModules;
        string degree;
        public DegreeAwardCalculator()
        {
                
        }

        public void CalculateFinalAward()
        {
            Console.Write("How many modules did you take?");
            numModules = int.Parse(Console.ReadLine());
            for(int i = 1; i <= numModules; i++)
            {
                Console.WriteLine($"Please enter the grade for Module {i}");
                double userGrade = double.Parse(Console.ReadLine());
                grades.Add(userGrade);
                Console.WriteLine($"Please enter the number of credits for Module {i}");
                double moduleWeight = double.Parse(Console.ReadLine());
                maxCredits += moduleWeight;
                gradesWeights.Add(moduleWeight);
                //AddToWeightedMean(userGrade, moduleWeight);
            }
            CalculateWeightedMean();
            CalculateMajorityGrade();
            CalculateDegree();
            Console.WriteLine($"Your weighted mean was: {weightedMean}");
            Console.WriteLine($"Your majority grade was: {majorityGrade}");
            Console.WriteLine($"Your awarded degree was: {degree}");
        }

        private void CalculateWeightedMean()
        {
            for(int i = 0; i < numModules; i++)
            {
                weightedMean += grades[i] * gradesWeights[i] / maxCredits;
            }
            weightedMean = Math.Round(weightedMean, 1);
            //weightedMean = weightedMean / numModules * maxGrade;
        }
        private void CalculateDegree()
        {
            var greatest = Math.Max(weightedMean, majorityGrade);
            greatest = Math.Round(greatest, 1);
            if(greatest <= 6.4)
            {
                degree = "Fail";
            }
            else if(greatest <= 9.4)
            {
                degree = "Pass";
            }
            else if(greatest <= 12.4)
            {
                degree = "Commendation";
            }
            else
            {
                degree = "Distinction";
            }

        }
        private void CalculateMajorityGrade()
        {
            //Determine the majority grade by finding the minimum classification that more than half the credits fall into(or higher).
            // put all grades into an array
            // sort array by lowest
            grades.Sort();
            //double halfGrades = numModules / 2;
            int halfOfCredits = (int)Math.Ceiling(maxCredits / 2.0);

            // loop through array to get the grade to be compared with as i
            for (int i = 0; i < grades.Count; i++)
            {
                double gradeToCompare = grades[i];
                int totalCreditsHigherThanThisGrade = 0;
                for(int j = 0; j < grades.Count; j++)
                {
                    if (grades[j] >= gradeToCompare)
                    {
                        totalCreditsHigherThanThisGrade += (int)gradesWeights[j];
                    }
                }
                if(totalCreditsHigherThanThisGrade >= halfOfCredits)
                {
                    majorityGrade = gradeToCompare;
                }
            }
            // loop through again to compare every grade against i
            // example. is j bigger than i? increment numOfClasses
            // check if numOfClasses == totalNumClasses / 2
            // if yes, assign majority grade to j
            // continue with the rest
        }
    }
}
