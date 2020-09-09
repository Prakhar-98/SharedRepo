using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        void Add()
        {
            int a, b;
            if(int.TryParse(Console.ReadLine(),out a) && int.TryParse(Console.ReadLine(),out b))
            {
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        void Subtract()
        {
            int a, b;
            if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine(a - b);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
