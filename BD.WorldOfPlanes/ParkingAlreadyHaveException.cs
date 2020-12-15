using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.WorldOfPlanes
{
    class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() : base("На аэродроме уже есть такой самолет.")
        {
        }
    }
}
