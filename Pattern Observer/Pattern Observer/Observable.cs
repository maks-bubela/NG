using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Observer
{
    class Observable
    {

        private List<IListener> observers;
        public Observable()
        {
            observers = new List<IListener>();
        }
        public void addObserver(IListener o)
        {
            observers.Add(o);
        }

        public void removeObserver(IListener o)
        {
            observers.Remove(o);
        }

        public void notify(Job job, string event_name)
        {
            foreach (IListener observer in observers)
                observer.Update(job, event_name);
        }
    }
}
