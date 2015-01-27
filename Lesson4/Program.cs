using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero(7, 8, "female");
            myHero.doesGoodThings();

            Console.WriteLine("press to exit");
            Console.ReadKey();
        }
    }
}
