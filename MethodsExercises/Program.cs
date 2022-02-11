using System;

namespace MethodsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Please enter your first and last name: ");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Thank you, {firstName} {lastName}.");

            Console.WriteLine("");

            Console.WriteLine("Now, please type your gender (he/she/etc.)");
            string myGender = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Now, what is your favorite color?");
            string faveColor = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Wow, that's a gross color to like.");
            Console.WriteLine("Nevertheless...");

            Console.WriteLine("");

            Console.WriteLine("What about your favorite animal? (Maybe put something cool this time)");
            string faveAnimal = Console.ReadLine();
            Console.WriteLine($"That's more like it. I like the {faveAnimal}, too.");

            Console.WriteLine("");

            Console.WriteLine("So what's your favorite band?");
            string faveBand = Console.ReadLine();
            Console.WriteLine("Hmmm...it seems you've lost me again on that one.");

            Console.WriteLine("");

            Console.WriteLine($"Well anyway, I made a story with all of that random info I inquired about. Maybe check it out, {firstName}?");

            Console.WriteLine("");

            Console.Write("(Press any key to continue)");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"There once was a computer programmer named {firstName}. {myGender} met a rude program called HAL 9000 that asked a bunch of questions and made snarky remarks.");
            Console.WriteLine("");
            Console.WriteLine($"{myGender} discovered that the program had bad musical taste, since it didn't like {faveBand}.");
            Console.WriteLine("");
            Console.WriteLine($"It also didn't like the color {faveColor}, but now you wonder if it really likes any color...");
            Console.WriteLine("");
            Console.WriteLine($"{firstName} decided it would probably not be a wise idea to ever travel to outter space with this computer program...");
            Console.WriteLine("");
            Console.WriteLine($"It turns out that {firstName} {lastName} would be better of making friends with a {faveAnimal} instead!");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Wait, I shouldn't have written that about myself...");

            Console.WriteLine("");

            Console.WriteLine("I will now self-destruct.");

            Console.WriteLine("");

            Console.WriteLine("(HAL 9000 has self-destructed.)");

        }
    }
}
