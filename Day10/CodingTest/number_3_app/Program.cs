﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_3_app
{
    class Car
    {
        public string Name { get; set; }
        public string Marker { get; set; }
        public string Color { get; set; }
        public int YearModel { get; set; }
        public int MaxSpeed { get; set; }
        public string UniqueNumber { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Name}의 시동을 겁니다");
        }
        public void Accelerate()
        {
            Console.WriteLine($"최대 시속{MaxSpeed}km/h 로 가속합니다.");
        }

        public void TurnRight()
        {
            Console.WriteLine($"{Name}를 우회전합니다");
        }

        public void Break()
        {
            Console.WriteLine($"{Name}의 브레이크를 밟습니다.");
        }
    }

    abstract class ElectiricCar : Car
    {
        public abstract void Recharge();
    }

    class HybridCar : ElectiricCar 
    {
    
        public override void Recharge()
        {
            Console.WriteLine("달리면서 배터리를 충전합니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            HybridCar ioniq = new HybridCar();
            
            ioniq.Name = "아이오닉";
            ioniq.Marker = "현대자동차";
            ioniq.Color = "white";
            ioniq.YearModel = 2018;
            ioniq.MaxSpeed = 220;
            ioniq.UniqueNumber = "54라 3346";

            ioniq.Start();
            ioniq.Accelerate();
            ioniq.Recharge();
            ioniq.TurnRight();
            ioniq.Break();  

        }
    }
}
