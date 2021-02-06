using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Observer
{
    class Job
    {
        private string vacancy;
        private string employer;
        private string company_name;
        private string info;
        public Job(string vacancy, string employer, string company_name, string info)
        {
            this.vacancy = vacancy;
            this.employer = employer;
            this.company_name = company_name;
            this.info = info;
        }
        public Job(string vacancy, string employer, string info)
        {
            this.vacancy = vacancy;
            this.employer = employer;
            this.info = info;
        }
        public Job()
        {
        }
        public string GetVacancy() { return this.vacancy; }
        public string GetEmployer() { return this.employer; }
        public string GetCompany_name() { return this.company_name; }
        public string GetInfo() { return this.info; }

    }
}
