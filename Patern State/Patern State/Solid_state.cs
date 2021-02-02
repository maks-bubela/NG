using System;
using System.Collections.Generic;
using System.Text;

namespace Patern_State
{
    class Solid_state : IState
    {
        public Solid_state(Context context)
        {
            context.state_name = "Solid state";
        }
        public void warm_up(Context context)
        {
            context.state = new Liquid_state(context);
        }
        public void cool(Context context) { }
    }
}
