using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Observer
{
    class Service
    {
        private List<Job> jobs;
        public Observable observervable;
        //private List<string> job_name;
        public Service()
        {
            this.jobs = new List<Job>();
            this.observervable = new Observable();
            //job_name = new List<string>();
        }
        public void AddJob(Job job)
        {
            this.jobs.Add(job);
            observervable.notify(job,"add");
        }
        public void RemoveJob(Job job)
        {
            this.jobs.Remove(job);
            observervable.notify(job, "remove");
        }
    }
}
