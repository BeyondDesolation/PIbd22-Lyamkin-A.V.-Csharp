using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.WorldOfPlanes
{
    class AirfieldNotFoundException : Exception
    {
        public AirfieldNotFoundException(int i) : base("Самолет на "+ i + " месте не найден")
        {

        }
    }
}
