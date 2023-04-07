using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs19_interface
{
    interface ILogger
    {
        void WriteLog(string log); 
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params object[] args); // args 다중 파라미터
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string log)
        {
            Console.WriteLine("{0} {1}",DateTime.Now.ToLocalTime(),log);
        }
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
            //throw new NotImplementedException();
        }
        public void WriteLog(string log)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), log);
        }
    }

    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public void Stop()
        {
            Console.WriteLine("정지!");
        }
    }

    interface IHoverable
    {
        void Hover();
    }

    interface IFlyable
    {
        void Fly();
    }

    class FlyHoverCar : Car, IFlyable, IHoverable
    {
        public void Fly()
        {
            Console.WriteLine("날다");
        }

        public void Hover()
        {
            Console.WriteLine("물에서 달린다");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("hi~");

            IFormattableLogger logger2 = new ConsoleLogger2();
            logger2.WriteLog("{0} x {1} = {2}", 6, 5, (6 * 5));
        
        }
    }
}
