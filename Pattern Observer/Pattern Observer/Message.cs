using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Observer
{
    class Message
    {
        public string mess_vacancy;
        public string mess_employer;
        public string mess_company_name;
        public string mess_info;
        public Message(Job job)
        {
            this.mess_vacancy = job.GetVacancy();
            this.mess_employer = job.GetEmployer();
            this.mess_company_name = job.GetCompany_name();
            this.mess_info = job.GetInfo();
        }
        public void ShowMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Vacancy : " + this.mess_vacancy);
            Console.WriteLine("Vacancy : " + this.mess_employer);
            Console.WriteLine("Vacancy : " + this.mess_company_name);
            Console.WriteLine("Vacancy : " + this.mess_info);
            Console.WriteLine();
        }
    }
}
