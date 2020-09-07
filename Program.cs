using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitasking_Design_Pattern
{
    class Program
    {  
        static void Main(string[] args)
        {
           // Console.WriteLine(Environment.ProcessorCount);
            Method1();
            Method2();
            Console.ReadLine();
        }

   static async Task Method1()
        {
            await Task.Run(() =>
            {
                for(int i=0;i<10;i++)
                {
                    Console.WriteLine("Method1");
                }
            });
        }
        static void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method2");
            }
        }

    }
}
