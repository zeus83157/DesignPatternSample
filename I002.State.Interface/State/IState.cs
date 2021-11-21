using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I002.State.Interface.State
{
    public interface IState
    {
        void Handle(Context context);
    }
}
