namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome new person! I hope you had a great trip for this new world");
            Console.WriteLine("You have died in your previous life and you got another life chance");
            Console.WriteLine("How do you wanna be called in your new life?");
            string playerName = Console.ReadLine();

            Console.WriteLine("Welcome to Chanalnia," + playerName + "");

            Console.WriteLine("My name is Saena. I'm your concious assistant throught this new life in this world");

            Console.WriteLine("What gender do you wanna be in your new life");
            string playerGender = Console.ReadLine();

            Console.WriteLine("That's great!" + playerGender + " is a great choice for a new life.");

            Console.WriteLine("Now," + playerName + " let's do some tutorial");

            Console.WriteLine("Press any key for next");
            Console.ReadKey();

        }
    }
}
