using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DmitrievLR.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.DmitrievLR.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3  ЦЕЛЫХ числа: ");
            string per_a = Console.ReadLine();

            string per_b = Console.ReadLine();

            string per_c = Console.ReadLine();

            int x = Convert.ToInt32(per_a);
            int y = Convert.ToInt32(per_b);
            int z = Convert.ToInt32(per_c);

            var result = DataService.Calc(x, y, z);

            Console.WriteLine("( " + x + " + " + y + " + " + z + " ) * 5 = " + result);


            Console.ReadKey();
        }
    }
}
