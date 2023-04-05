using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs10_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트연산 << == *2 / >> == /2
            int firstval = 0b1111; // 15
            int secondval = firstval << 1; // 0x11110
            Console.WriteLine(secondval);

            firstval = 0b1111;
            secondval = 0b1101;
            Console.WriteLine(firstval&secondval);

            firstval = 0b1010;
            secondval = 0b0101;
            Console.WriteLine(firstval | secondval);
            Console.WriteLine(~secondval);

            int? checkval = null;
            Console.WriteLine(checkval== null? 0:checkval);
            Console.WriteLine(checkval??0); // null 병합연산자는 3항연산자를 더 축소

            checkval = 25;
            Console.WriteLine(checkval.HasValue? checkval.Value : 0);
            Console.WriteLine(checkval ?? 0);

        }
    }
}
