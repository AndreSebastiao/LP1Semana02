using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string question;

            //While the user does type "EXIT", the program will continue to function
            do 
            {
                Console.WriteLine("Ask me anything!");
                question = Console.ReadLine();

                switch (question)
                {
                    case "What is the meaning of life?":
                        Console.WriteLine("That's easy, 42!");
                        break;
                    case "What's the best game ever created?":
                        Console.WriteLine("Easily Kurofune");
                        break;
                    case "Where can i find Kurofune?":
                        Console.WriteLine("It's available as of the 28th of February on Steam");
                        break;

                    case "Well, is it free?":
                        Console.WriteLine("As it is a Demo, it is free!");
                        break;
                }   
            }   while (question != "EXIT");
        }
    }
}
