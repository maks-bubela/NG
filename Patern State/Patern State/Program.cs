using System;

namespace Patern_State
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice="";
            Context context = new Context();
            while (choice != "0")
            {
                Console.WriteLine("Your action : \n" +
                     "1. warm up\n" +
                     "2. cool\n" +
                     "0. exit");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    context.Warm_up();
                    Console.WriteLine(context.state_name);
                }
                else if (choice == "2")
                {
                    context.Cool();
                    Console.WriteLine(context.state_name);
                }
            }
        }
    }
}
