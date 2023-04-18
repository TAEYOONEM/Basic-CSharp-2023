using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_2_app
{

    public class Boiler
    {
        //public string brand;
        private byte voltage;
        private int temperature;

        public string Brand
        {
            get; set;
        }
        public byte Voltage
        {
            get { return voltage; }
            set 
            {
                if (value == 110 || value == 200)
                    voltage = value;
                else 
                    voltage = 0;
            }
        }
        public int Temperature
        {
            get => temperature;
            set
            {
                if (value < 5)
                    this.temperature = 5;
                else if (value > 70)
                    this.temperature = 70;
                else
                    this.temperature = value;
            }
        }

        public void PrintAll()
        {
            Console.WriteLine($"Brand = {Brand}, Voltage = {Voltage}, Temperature = {Temperature}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Boiler kitturami1 = new Boiler() { Brand = "귀뚜라미1", Voltage = 110, Temperature = 0 };
            Boiler kitturami2 = new Boiler() { Brand = "귀뚜라미2", Voltage = 220, Temperature = 100 };
            Boiler kitturami3 = new Boiler() { Brand = "귀뚜라미3", Voltage = 10, Temperature = 45 };

            kitturami1.PrintAll();
            kitturami2.PrintAll();
            kitturami3.PrintAll();

        }
    }
}
