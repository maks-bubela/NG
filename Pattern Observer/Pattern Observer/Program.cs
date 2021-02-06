using System;
using System.Collections.Generic;
using System.Reflection;

namespace Pattern_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_vacancy;
            string user_employer;
            string user_company_name;
            string user_info;

            int user_id;

            string choice = "";
            Service service = new Service();
            List<Listener> listener = new List<Listener>();

            while(choice != "0")
            {
                Console.WriteLine("What you want to do : \n" +
                    "1. Add new user \n" +
                    "2. Add new job \n" +
                    "3. Remove job \n" +
                    "4. Select user\n" +
                    "0. Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1" :
                        listener.Add(new Listener());
                        break;

                    case "2":
                        Console.Write("Vacancy : ");
                        user_vacancy = Console.ReadLine();
                        Console.Write("Employer : ");
                        user_employer = Console.ReadLine();
                        Console.Write("Company name : ");
                        user_company_name = Console.ReadLine();
                        Console.Write("Info : ");
                        user_info = Console.ReadLine();
                        service.AddJob(new Job(user_vacancy,user_employer,user_company_name,user_info));
                        break;

                    case "3":
                        Console.Write("Vacancy : ");
                        user_vacancy = Console.ReadLine();
                        Console.Write("Employer : ");
                        user_employer = Console.ReadLine();
                        Console.Write("Company name : ");
                        user_company_name = Console.ReadLine();
                        Console.Write("Info : ");
                        user_info = Console.ReadLine();
                        service.RemoveJob(new Job(user_vacancy, user_employer, user_company_name, user_info));
                        break;

                    case "4":
                        Console.Write("Enter user id : ");
                        user_id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What you want to do : \n" +
                            "1. Subscribe \n" +
                            "2. Unsubscribe \n" +
                            "3. Check message");
                        choice = Console.ReadLine();
                        if (choice == "1")
                            service.observervable.addObserver(listener[user_id]);
                        else if (choice == "2")
                            service.observervable.removeObserver(listener[user_id]);
                        else if (choice == "3")
                            listener[user_id].showMessage();
                        break;

                }
            }
            //service.observervable.addObserver();
        }
    }
}
