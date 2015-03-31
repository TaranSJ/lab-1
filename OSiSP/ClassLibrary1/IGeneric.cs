using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface IGeneric<out T> where T : room
    {
        T GetType();
    }
}
