namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            string dogName;
            int dogAge;
            char middleInitial;
            double biteChance;
            decimal vetPrice = 100.5m;
            bool IsDataCorrect;

            Console.WriteLine("Welcome to the Vet! Whats your dog's name?");
            dogName = Console.ReadLine();

            Console.WriteLine($" How old is {dogName}?");
            dogAge = Int32.Parse((Console.ReadLine()));

            Console.WriteLine($"What's {dogName} middle initial?");
            middleInitial = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"What's the chances that {dogName} will bite someone?");
            biteChance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please review the information:"
                + $" Dog Name: {dogName}, Age: {dogAge},  Middle Initial: {middleInitial}," +
                $" Bite Chance: {biteChance}");

            Console.WriteLine(" ");

            Console.WriteLine("Is the data correct? Please type True or False");
            IsDataCorrect = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"You have answered: {IsDataCorrect}. Your total price is {vetPrice}");


        }
    }
}
