using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    // extended generic class for test contravariation
    public class tv : room
    {
        public string Name;
        // method which never used but needed for show difference between classes
        public string GetName()
        {
            return Name;
        }
    }
}
