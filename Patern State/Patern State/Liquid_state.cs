using System;
using System.Collections.Generic;
using System.Text;

namespace Patern_State
{
    class Liquid_state : IState
    {
        public Liquid_state(Context context)
        {
            context.state_name = "Liquid state";
        }
        public void warm_up(Context context)
        {
            context.state = new Gaseous_state(context);
        }
        public void cool(Context context)
        {
            context.state = new Solid_state(context);
        }
    }
}
