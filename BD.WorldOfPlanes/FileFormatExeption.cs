using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.WorldOfPlanes
{
    class FileFormatExeption : Exception
    {
        public FileFormatExeption() : base("Формат файла не соответствует требованиям")
        {

        }
    }
}
