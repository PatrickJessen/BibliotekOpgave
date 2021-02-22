using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            RentSystem rent = new RentSystem();
            rent.SelectBookToRent();
        }
    }
}
