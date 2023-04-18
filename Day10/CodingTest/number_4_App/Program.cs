using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_4_App
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, string> dict = new Dictionary <string, string>();
            dict["red"] = "빨간색";  
            dict["orange"] = "주황색";  
            dict["yello"] = "노란색";  
            dict["green"] = "초록색";
            dict["blue"] = "파랑색";  
            dict["indigo"] = "빨간색";  
            dict["purple"] = "보라색";  

            Console.Write("무지개색은 ");
            foreach (var key in dict.Keys)
            {
                Console.Write($"{dict[key]} ");
            }
            Console.WriteLine("입니다.");

            Console.WriteLine("Key와 Value 확인");

            Console.WriteLine($"Purple은 {dict["purple"]}");


        }
    }
}
