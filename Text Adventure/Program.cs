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
            Console.WriteLine("I'm going to help you make life choices");

            Console.WriteLine("What gender do you wanna be in your new life");
            string playerGender = Console.ReadLine();

            Console.WriteLine("That's great!" + playerGender + " is a great choice for a new life.");

            Console.WriteLine("Now," + playerName + " let's do some life choices...");

            Console.WriteLine("In this world there is 2 mini world");
            Console.WriteLine("First, We have The Underground that is inhabited by the Chanalniacian ");
            Console.WriteLine("First, We have The Ground that is inhabited by the Chanalnian ");
            Console.WriteLine("In The Underground you will be an expert in technology and even be a Technomancer." +
            "But in The Ground you will be in a mysthic world and even be a dragon slayer or choose your own power ");
            Console.WriteLine("Do you want to do live in The Underground or The Ground?");

            // Prompt user for a choice
            string worldChoice = Console.ReadLine().ToLower();

            if (worldChoice == "The Underground")
            {
                Console.WriteLine("You are now in The Underground...");
                Console.WriteLine("As you can see, you have to choose if you want to be a Technomancer or not");
                Console.WriteLine("Do you want to be a Technomancer or not? (yes/no)");

                string technomancerChoice = Console.ReadLine().ToLower();
                if (technomancerChoice == "yes")
                {
                    Console.WriteLine("Yor are now a Technomancer of level 1. If you train hard you can increase your level");
                }
                else if (technomancerChoice == "no")
                {
                    Console.WriteLine("You wisely decide not to be a technomancer but an expert in technology.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter yes or no.");
                }
            }
            else if (worldChoice == " The Ground")
            {
                Console.WriteLine("You are now in The Ground...");
                Console.WriteLine("As you can see, you have to choose if you want to choose your power");
                Console.WriteLine("What power do you want to aquire?");
                string powwerchoice = Console.ReadLine();

                // Additional story for the dining room could go here
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter  The Underground or The Ground");


                Console.WriteLine("Press any key for next");
                Console.ReadKey();


            }
        }
    }
}
