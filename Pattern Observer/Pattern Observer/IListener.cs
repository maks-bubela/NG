using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Observer
{
    interface IListener
    {
        void Update(Job job, string event_name);
    }
}
