using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_5_App
{
    interface IAnimal
    {
        void Eat();
        void Sleep();
        void Sound();
    }

    abstract class Animal : IAnimal
    {
        public string Name { get; set; }
      
        public int Age { get; set; }    

        public void Eat()
        {
            Console.WriteLine($"{Name}가 밥을 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name}가 잠을 잡니다.");
        }

        public abstract void Sound();
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("멍멍!");
        }
    }
    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("야옹!");
        }
    }
    class Horse : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("히이잉!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Cat c = new Cat();
            Horse h = new Horse();

            d.Name = "개서스";
            d.Age = 10;
            d.Eat();
            d.Sleep();
            d.Sound();

            c.Name = "유미";
            c.Age = 10;
            c.Eat();
            c.Sleep();
            c.Sound();

            h.Name = "헤카림";
            h.Age = 10;
            h.Eat();
            h.Sleep();
            h.Sound();

        }
    }
}
