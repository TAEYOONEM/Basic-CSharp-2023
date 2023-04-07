using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs17_inheritance
{
    // 상속해줄 부모 클래스
    class Parent
    {
        protected string Name; // 상속 할떄는 private을 쓰면 안됨
        public Parent(string Name) 
        { 
            this.Name = Name;
            Console.WriteLine("{0} from Parent 생성자", this.Name);
        
        }

        public void ParentMethod()
        {
            Console.WriteLine("{0} from Parent 메서드",Name);
        }
    }

    class Child : Parent 
    {
        public Child(string Name) : base(Name) // 부모 생성자를 먼저 실행한뒤 자신 생성자를 실행
        {
            Console.WriteLine("{0} from Child 생성자", this.Name);
        }    
        
        public void ChildMethod() 
        {
        
            Console.WriteLine("{0} from Child 메서드", Name);
        
        }
      
    }

    // 클래스 간 형 변환
    class Mammal // 포유류
    {
   
        public void Nurse() 
        {
            Console.WriteLine("포유류 기르다");
        }
    }

    class Dogs : Mammal
    {

        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Cats: Mammal
    {
        public void Meow()
        {
            Console.WriteLine("냥냥");
        }
    }

    class Elephant : Mammal
    {
        public void Pooo()
        {
            Console.WriteLine("뿌");
        }
    }

    class ZooKeeper
    {
        public void Wash(Mammal mammal)
        {
            if(mammal is Elephant)
            {
                var animal = mammal as Elephant;    
                Console.WriteLine("코끼리를 씻깁니다.");
                animal.Pooo();
            }
            
            else if (mammal is Dogs)
            {
                var animal = mammal as Dogs;
                Console.WriteLine("강아지를 씻깁니다.");
                animal.Bark();
            }
            
            else if (mammal is Cats)
            {
                var animal = mammal as Cats;
                Console.WriteLine("고양이를 씻깁니다.");
                animal.Meow();
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)

        {
            #region < 기본상속 개념 >

            Parent p = new Parent("p");
            p.ParentMethod();

            Console.WriteLine("------");

            Child c = new Child("c");
            c.ParentMethod(); // 자식 클래스는 부모클래스의 속성, 기능을 모두 쓸 수 있다.(Public , Protected일때)
            c.ChildMethod();

            #endregion

            #region < 클래스 간 형식변환 >

            //Mammal mammal = new Mammal();   
            Mammal mammal = new Dogs();
            //mammal.Bark(); // 바로 안됨
            if(mammal is Dogs)
            {
                Dogs midDog = mammal as Dogs; //Dogs midDog = (Dogs)mammal;
                midDog.Bark();
            }


            //Dogs dogs = new Mammal(); // 부모 클래스가 자식클래스로 변환은 불가
            Dogs dog2 = new Dogs();
            Cats cat2 = new Cats(); 
            Elephant el2 = new Elephant();  


            ZooKeeper zooKeeper = new ZooKeeper();
            zooKeeper.Wash(dog2);
            zooKeeper.Wash(cat2);
            zooKeeper.Wash(el2);
            
            #endregion


        }
    }
}
