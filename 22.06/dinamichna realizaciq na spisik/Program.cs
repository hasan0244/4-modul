using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinamichna_realizaciq_na_spisik
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList ds = new DynamicList();
            ds.Add(4);
            ds.Add(5);
            ds.Add(6);
            object t = 15;
            
            Console.WriteLine(ds[1]);
            
        }
    }
}
