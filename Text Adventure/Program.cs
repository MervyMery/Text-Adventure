namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variables and Console
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

           

            Console.Beep(1005, 1000);

            int age = 22;
            double distance = 140.12;
            char Roweysymbol = '@';

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(age);

            Console.WriteLine("Welcome new person! I hope you had a great trip for this new world");
            Console.WriteLine("You have died in your previous life and you got another life chance");
            Console.WriteLine("The only thing you can't change in this life is the age. Since you died at the age of " + age + " years old. You will continue to live from that age");
            Console.WriteLine("How do you wanna be called in your new life?");
            string playerName = Console.ReadLine();

            Console.WriteLine("Welcome to Chanalnia," + playerName + "");

            Console.WriteLine("My name is Saena. I'm your concious assistant throught this new life in this world");
            Console.WriteLine("I'm going to help you make life choices");

            Console.WriteLine("What gender do you wanna be in your new life");
            string playerGender = Console.ReadLine();

            Console.WriteLine("That's great!" + playerGender + " is a great choice for a new life.");

            Console.WriteLine("Now," + playerName + " let's do some life choices...");

            Console.WriteLine("In this world there is 2 mini worlds");
            Console.WriteLine("First, we have The Underground that is inhabited by the Chanalniacian ");
            Console.WriteLine("On the second, we have The Ground that is inhabited by the Chanalnian ");
            Console.WriteLine("The mini worlds are far from each other of" + distance + "miles");
            Console.WriteLine("In The Underground you will be an expert in technology and even be a Technomancer." +
            "But in The Ground you will be in a mysthic world and even be a dragon slayer or choose your own power ");
            Console.WriteLine("Do you want to do live in The Underground or The Ground?");

            // Enums: Prompt player for a choice
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


            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter  The Underground or The Ground");

            }
           
            // Opperators
            Console.WriteLine("In your previous life, MONEY was  everything...");
            Console.WriteLine("In this life too it will be the same. In Chanalnia we use Rowey for our curency for your daily use.");
            Console.WriteLine("For the beginning of your life How much would do like? Think wisely because after this amount you will have to work to get more.");

            double rowey = Convert.ToDouble(Console.ReadLine());

            if (rowey >=1 && rowey <= 20000)
            {

                Console.WriteLine("Ouf, I thought you will ask for 1000000000 ");
                Console.WriteLine("Okay you will get" + rowey + Roweysymbol);
            }
            else if (rowey <= 0 || rowey >= 30000)
            {
                Console.WriteLine("EXCUSE YOUUUUUUUUUU !! Are you okay? ");
            }

            Console.WriteLine("Press any key for next");
                Console.ReadKey();


            }
        }
    }