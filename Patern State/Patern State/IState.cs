using System;
using System.Collections.Generic;
using System.Text;

namespace Patern_State
{
    interface IState
    {
        public abstract void warm_up(Context context);
        public abstract void cool(Context context);
    }
}
