using System;
using System.Collections.Generic;
using System.Text;

namespace Patern_State
{
    class Context
    {
        public string state_name;
        public IState state { get; set; }
        public Context()
        {
            this.state = new Liquid_state(this);
        }
        public void Warm_up()
        {
            this.state.warm_up(this);
        }
        public void Cool()
        {
            this.state.cool(this);
        }
    }
}
