using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favoirte subject?");
            var subject = Console.ReadLine();
            

            switch (subject)
            {
                case "English":
                    Console.WriteLine("English is cool!");
                    break;

                case "Math":
                    Console.WriteLine("Math is Awesome!");
                    break;


                case "Science":
                    Console.WriteLine("Science is my favorite!");
                    break;


                case "History":
                    Console.WriteLine("Boring!");
                    break;


                case "PE":
                    Console.WriteLine("Chill Time!");
                    break;
                default:
                    Console.WriteLine("Never took that subject before.");
                    break;

                
                 







            }
        }
    }
}
