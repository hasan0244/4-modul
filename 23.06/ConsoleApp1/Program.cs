using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> ars = new ArrayStack<int>();
            ars.Push(2);
            ars.Push(7);
            ars.Push(5);
            Console.WriteLine(String.Join(" ",ars.ToArray));
        }
    }
}
