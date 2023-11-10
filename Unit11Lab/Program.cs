using Unit6Lab;

namespace Unit11Lab
{
    struct IceCream
    {
        public string flavour;
        public decimal price;
        public int calories;
    }
    internal class Program
    {
        static IceCream MakeNewIceCream()
        {
            try
            {
                IceCream newFlavor;
                Console.WriteLine("Enter a flavor: ");
                newFlavor.flavour = Console.ReadLine();
                Console.WriteLine("Enter a price: ");
                newFlavor.price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter the amount of calories: ");
                newFlavor.calories = int.Parse(Console.ReadLine());
                return newFlavor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("You probably didn't enter a real number.");
                throw;
            }

        }

        static void DisplayFlavors(IceCream[] flavors)
        {
            for (int i = 0; i < flavors.Length; i++)
            {
                Console.WriteLine($"{flavors[i].flavour} ice cream costs ${flavors[i].price} and contains {flavors[i].calories} kcals.");
            }
        }
        static void Main(string[] args)
        {
            Quiz2 quiz = new Quiz2();
            quiz.PlayQuiz();

            //NewCinema cinema = new NewCinema();
            //cinema.GoToCinema();

            //IceCream van;
            //van.flavour = "Vanilla";
            //van.price = 1.99m;
            //van.calories = 207;

            //IceCream choc;
            //choc.flavour = "Chocolate";
            //choc.price = 2.49m;
            //choc.calories = 216;

            //IceCream[] flavors = new IceCream[3];
            //IceCream newFlavor = MakeNewIceCream();
            //flavors[0] = van;
            //flavors[1] = choc;
            //flavors[2] = newFlavor;

            //DisplayFlavors(flavors);

        }
    }
}