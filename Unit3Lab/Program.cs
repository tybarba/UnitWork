using System.Runtime.CompilerServices;

namespace Unit3Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONSTANTS PRACTICE
            //TAX CALCULATOR
            const double basicTaxRate = 0.2;
            const double higherTaxRate = 0.4;
            const double additionalTaxRate = 0.45;
            const double basicRateLimit = 37700;
            const double higherTaxLimit = 125140;
            const double basePersonalAllowance = 12570;

            double GetPersonalAllowance(double userGrossAnnualIncome)
            {
                const double personalAllowanceUpperLimit = 100000;
                double grossIncomeAboveLimit = userGrossAnnualIncome - personalAllowanceUpperLimit;
                double personalAllowance = basePersonalAllowance;
                if(grossIncomeAboveLimit > 0)
                {
                    personalAllowance = basePersonalAllowance - grossIncomeAboveLimit * 0.5;
                    if(personalAllowance < 0)
                    {
                        personalAllowance = 0;
                    }
                }
                return personalAllowance;
            }

            double GetTaxableIncome(double userGrossAnnualIncome, double userPersonalAllowance)
            {
                double taxableIncome = userGrossAnnualIncome - userPersonalAllowance;
                if(taxableIncome < 0)
                {
                    taxableIncome = 0;
                }
                return taxableIncome;
            }

            double CalculateTaxes(double userTaxableIncome)
            {
                double taxPayable = 0;
                double remainder;
                double taxableAmountAtThisBracket;
                //check if user income is less than limit
                    //if yes, taxable amount = income or remaining amount from previous bracket
                    //tax payable = taxable amount * rate + previous tax payable amount
                //if not, taxable amount = thisBracketlimit - previous bracket limit
                    //calculate tax for the amount at bracket and add to total
                    //repeat

                if (userTaxableIncome <= basicRateLimit)
                {
                    taxableAmountAtThisBracket = userTaxableIncome;
                    taxPayable = taxableAmountAtThisBracket * basicTaxRate;
                    return taxPayable;
                }
                else
                {
                    taxableAmountAtThisBracket = basicRateLimit;
                    taxPayable += taxableAmountAtThisBracket * basicTaxRate;
                    remainder = (userTaxableIncome - basicRateLimit);
                }

                if(userTaxableIncome <= higherTaxLimit)
                {
                    taxableAmountAtThisBracket = remainder;
                    taxPayable += taxableAmountAtThisBracket * higherTaxRate;
                    return taxPayable;
                }
                else
                {
                    taxableAmountAtThisBracket = higherTaxLimit - basicRateLimit;
                    taxPayable += taxableAmountAtThisBracket * higherTaxRate;
                    remainder = (userTaxableIncome - higherTaxLimit);
                }
                taxableAmountAtThisBracket = remainder;
                taxPayable += remainder * additionalTaxRate;
                return taxPayable;             
            }
            bool continuePlaying = true;
            while (continuePlaying)
            {
                Console.Write("Please enter your annual income. DO NOT include commas. \n$");

                string userAnnualIncomeString = Console.ReadLine();
                double userGrossAnnualIncome = double.Parse(userAnnualIncomeString);
                double userPersonalAllowance = GetPersonalAllowance(userGrossAnnualIncome);
                double userTaxableIncome = GetTaxableIncome(userGrossAnnualIncome, userPersonalAllowance);
                double userPayableTaxes = CalculateTaxes(userTaxableIncome);

                Console.WriteLine("Your gross annual income is: $" + userGrossAnnualIncome);
                Console.WriteLine("Your Personal Allowance is: $" + userPersonalAllowance);
                Console.WriteLine("Your taxable income is: $" + userTaxableIncome);
                Console.WriteLine("Your income taxes are: $" + +userPayableTaxes);

                Console.WriteLine("Play again? y/n");
                continuePlaying = (Console.ReadLine() == "y");
            }




            ////QUIZ
            //int userScore = 0;

            //string correctAnswerMessage = $"That's correct. Your score is: {userScore}/3";
            //string wrongAnswerMessage = $"That's wrong. Your score is: {userScore}/3";

            //void updateMessages()
            //{
            //    correctAnswerMessage = $"That's correct. Your score is: {userScore}/3";
            //    wrongAnswerMessage = $"That's wrong. Your score is: {userScore}/3";
            //}

            //string followUp = "Enter your answer: ";
            //string question1 = "What is the official language of the USA?\n\tA. English\n\tB. Spanish\n\tC. None";
            //string question1Answer = "C";
            //string question2 = "How many questions are in this quiz?\n\tA. 5\n\tB. 3\n\tC. 4";
            //string question2Answer = "B";
            //string question3 = "What's my favorite brand of crisps?\n\tA. Cheetos\n\tB. Doritos\n\tC. Pringles";
            //string question3Answer = "B";

            //Console.WriteLine("Welcome to my quiz!\n\n");

            //Console.WriteLine(question1);
            //Console.Write(followUp);
            //string userAnswer1 = Console.ReadLine().ToUpper();
            //if(userAnswer1 == question1Answer)
            //{
            //    userScore++;
            //    updateMessages();
            //    Console.WriteLine(correctAnswerMessage);
            //}
            //else
            //{
            //    Console.WriteLine(wrongAnswerMessage);
            //}

            //Console.WriteLine(question2);
            //Console.Write(followUp);
            //string userAnswer2 = Console.ReadLine().ToUpper();
            //if (userAnswer2 == question2Answer)
            //{
            //    userScore++;
            //    updateMessages();
            //    Console.WriteLine(correctAnswerMessage);
            //}
            //else
            //{
            //    Console.WriteLine(wrongAnswerMessage);
            //}

            //Console.WriteLine(question3);
            //Console.Write(followUp);
            //string userAnswer3 = Console.ReadLine().ToUpper();
            //if (userAnswer3 == question3Answer)
            //{
            //    userScore++;
            //    updateMessages();
            //    Console.WriteLine(correctAnswerMessage);
            //}
            //else
            //{
            //    Console.WriteLine(wrongAnswerMessage);
            //}
        }
    }
}