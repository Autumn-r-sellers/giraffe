using System;

namespace Giraffe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string user =  Console.ReadLine();
            Console.WriteLine("Hello " + user);
            string response = Console.ReadLine();
            while (true)
            {
                if (response.ToLower() == "hello")
                {
                    Console.WriteLine("How are you today?");
                }
                else
                {
                    Console.WriteLine("Do you not know common courtesy?");
                    break;
                }
                string goodResponse = Console.ReadLine();

                if (goodResponse.ToLower() == "good")
                {
                    Console.WriteLine("I am glad to hear that! I hope you have a great day!");
                    break;
                }
                else if (goodResponse.ToLower() == "I am good")
                {
                    Console.WriteLine("I am glad to hear that! I hope you have a great day!");
                    break;
                }
                else if (goodResponse.ToLower() == "I am well")
                {
                    Console.WriteLine("I am glad to hear that! I hope you have a great day!");
                    break;
                }
                else
                {
                    Console.WriteLine("I am so sorry to hear that. Can I say anything to make you feel better?");
                }

                string badResponse= Console.ReadLine();

                if(badResponse.ToLower() == "no")
                {
                    Console.WriteLine("I am so sorry to hear that. I hope your day gets better.");
                    break;
                }else
                {
                    Console.WriteLine("Well, I am not very good at words, but I think you are a beautiful human and deserve the world. I hope your day gets better.");
                    break;
                }
            }


        }
    }
}
