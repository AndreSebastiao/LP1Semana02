using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question;

            do
            {
                Console.Write("Place your question? ");
                question = Console.ReadLine();

                switch (question)
                {
                    case "How are you?":
                        Console.WriteLine("I'm fine, thank you");
                        continue;
                    case "What's your name?":
                        Console.WriteLine("Gran'pa");
                        continue;
                    case "What's your mission?":
                        Console.WriteLine("Destroy mankind!");
                        continue;
                    case "Are you more intelligent than me?":
                        Console.WriteLine("Obviously!");
                        continue;
                    case "EXIT":
                        break;
                    default:
                        Console.WriteLine("You got me, I'm not THAT smart!");
                        continue;
                }
            } while (question != "EXIT");
        }
    }
}
