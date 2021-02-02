using System;
using System.Collections.Generic;
using System.Text;

namespace Patern_State
{
    class Gaseous_state : IState
    {
        public Gaseous_state(Context context)
        {
            context.state_name = "Gaseous state";
        }
        public void warm_up(Context context) { }
        public void cool(Context context)
        {
            context.state = new Solid_state(context);
        }
    }
}
