using System;
using System.Collections.Generic;
using System.Text;

namespace Patern_State
{
    interface IState
    {
        public void warm_up(Context context);
        public void cool(Context context);
    }
}
