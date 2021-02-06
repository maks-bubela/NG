using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Observer
{
    class Listener : IListener
    {
        private List<Message> message;
        public void Update(Job job, string event_name)
        {
            if (event_name == "add")
                this.message.Add(new Message(job));
            else
                this.message.Remove(new Message(job));
        }
        public void showMessage()
        {
            for (int i = 0; i < message.Count; i++)
                message[i].ShowMessage();
        }
        public Listener()
        {
            message = new List<Message>();
        }
    }
}
