using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cs13_class // private 이라도 같은 cs13_class안에 있기 떄문에 접근가능
{
    internal class Cat
    {
        #region< 생성자 >
        public Cat()
        {
            Name = string.Empty;
            Color = string.Empty;
            Age = 0;
        }

        public Cat(string name, string color, SByte age) {}

        #endregion

        #region < 멤버변수 - 속성>
        public string Name;
        public string Color;
        public SByte Age; // 0~ 255
        #endregion


        #region < 멤버메서드 - 기능 >
        public void Meow()
        {
            Console.WriteLine("{0} - meow",Name);
        }

        public void Run() {
            Console.WriteLine("{0} - RUN", Name);
        }
        #endregion

    }

    internal class Program // internal -> cs13_class 안에선 어디든 사용가능
    {
        static void Main(string[] args)
        {
            Cat helloKitty = new Cat(); // helloKitty 라는 이름의 객체를 생성할게
            helloKitty.Name = "헬로키티";
            helloKitty.Color = "흰색";
            helloKitty.Age = 50;
            helloKitty.Meow();
            helloKitty.Run();

            // 객체를 생성하면서 속성 초기화
            Cat nero = new Cat() {
                Name = "검은 고양이 네로",
                Color = "검은색",
                Age = 27,
            };

            nero.Meow();
            nero.Run();

            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다."
                ,helloKitty.Name,helloKitty.Color,helloKitty.Age);
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다."
        , nero.Name, nero.Color, nero.Age);
        }
    }
}
