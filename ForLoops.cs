using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class ForLoops
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            //int i=1 '1den başla)
            //i <=100 (i100den küçük eşit olsun yani 100e kadar yazsın)
            //i++ (i'yi bir arttır)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
            Console.ReadLine();
        }
    }
}
