using EFDemo.Data;
using EFDemo.Model;
using System;
using System.Linq;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using var context = new DemoContext();
                context.Leagures.firs
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
