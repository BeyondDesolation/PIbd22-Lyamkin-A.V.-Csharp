using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.WorldOfPlanes
{
    class AddingToAirfiledExeption : Exception
    {

        public AddingToAirfiledExeption(String airfieldName) : base("Не удалось добавть самолет на аэродром " + airfieldName)
        {

        }
    }
}
