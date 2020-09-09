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
            Console.WriteLine("Enter 2 numbers");
            int a, b;
            if(int.TryParse(Console.ReadLine(),out a) && int.TryParse(Console.ReadLine(),out b))
            {
                if (a == 0 || b == 0)
                    Add();
                Console.WriteLine(a + b);

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        void Subtract()
        {
            Console.WriteLine("Enter 2 numbers");
            int a, b;
            if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
            {
                if (a == 0 || b == 0)
                    Subtract();
                Console.WriteLine(a - b);

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
