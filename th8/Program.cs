using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace th8
{
    
    internal class Program
    {
        /// <summary>
        /// Основной метод
        /// </summary>
        /// <param name="args">Параметр основного метода</param>
        
        static void Main(string[] args)
        {
            Write("Enter x: ");
            int x = Convert.ToInt32(ReadLine());
            Write("Enter y: ");
            int y = Convert.ToInt32(ReadLine());
            Swap(ref x, ref y);
            WriteLine($"{x}\t{y}");
            ReadKey();
        }
        
        /*static void Main(string[] args)
        {
            int a = 5;
            WriteLine($"a = {a}");
            IncrementVal(ref a);
            WriteLine($"a = {a}");
            ReadKey();
        }*/
        /// <summary>
        /// Дополнительный метод
        /// </summary>
        /// <param name="">Параметр дополнительного метода</param>
        /// 

        static void Swap(ref int x, ref int y)
        {
            int p = x;
            x = y;
            y = p;
        }


        /*static void IncrementVal(ref int x)
        {
            x++;
            WriteLine($"IncrementVal: {x}");
        }*/

        
        
    }
}
