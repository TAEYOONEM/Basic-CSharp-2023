using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs12_methods
{
    class Calc { 
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b) {
            return a - b;
        }
    }
    internal class Program
    {
        /// <summary>
        /// 실행 시 메모리에 최초 올라가야 하기 떄문에 static이 되어야 하고
        /// 메서드 이름이 Main 이면 실행될떄 알아서 제일 처음에 시작됨.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region < static 메서드 >
            int result = Calc.Plus(1, 2); 
            // static은 최초실행 때 메모리에 바로 올라가기 때문에 
            // 클래스를 객체를 만들필요가 없다. Like new Calc();
            
            //Calc.Minus(3, 2); // Minus는 static이 아니기때문에 접근불가(객체 생성해야 접근가능)
            result = new Calc().Minus(3, 2);
            Console.WriteLine(result);
            #endregion

            #region< Call by referenc  VS Call by value >
            int x = 10, y = 3;
            swap(ref x,ref y);
            
            Console.WriteLine("x = {0} , y = {1}",x,y);

            Console.WriteLine( GetNumber());
            #endregion

            #region< out 매개변수 >
            int divid = 10;
            int divor = 3;
            int rem = 0;

            //Divide(divid, divor, ref result, ref rem);
            Divide(divid, divor, out result, out rem); // ref를 쓰든 out을 쓰든 다르지 않지만 out 권장
            Console.WriteLine("나누기 값 : {0}, 나머지 : {1}", result, rem);

            (result, rem) = Divide(divid, divor);   
            Console.WriteLine("나누기 값 : {0}, 나머지 : {1}", result, rem);

            #endregion

            #region < 가변길이 매개변수 >

            Console.WriteLine(Sum(1,2,3,4,5,6,7,8,9,10));

            #endregion
        }

        // Main 메서드와 같은 레벨이 있는 메서드들은 전부 무조건 static이 되어야 함
        //static int Divide(int x, int y)
        //{
        //    return x / y;
        //}
        //static int Reminder(int x, int y)
        //{
        //    return x % y;
        //} // 메서드 두개 만들걸 아래처럼 하나로
        static void Divide(int x, int y,out int val, out int rem)
        {
            val = x / y;
            rem = x % y;
        }

        static (int result, int rem) Divide(int x, int y)
        {
            return (x/y, x%y); // C# 7.0
        }


        public static void swap(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static int val = 100;
        public static ref int GetNumber()
        {
            return ref val; // static 메서드에 접근할 수 있는 변수는 static 밖에 없음
        }

        public static int Sum(params int[] args) 
        {
            int sum = 0;

            foreach (var item in args) {
                sum += item;
            }

            return sum;
        }
    }
}
