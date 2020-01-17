using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MilitaryTimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Conv conv = new Conv();

            Console.WriteLine(conv.MilitaryTimeToRegularTime("00:00"));
            Console.WriteLine(conv.MilitaryTimeToRegularTime("01:00"));
            Console.WriteLine(conv.MilitaryTimeToRegularTime("12:00"));
            Console.WriteLine(conv.MilitaryTimeToRegularTime("18:00"));
            Console.WriteLine(conv.MilitaryTimeToRegularTime("01:60"));
            Console.WriteLine(conv.MilitaryTimeToRegularTime("03!50"));
            Console.WriteLine(conv.MilitaryTimeToRegularTime("18:0x"));

            Console.ReadKey();
        }
    }
}
