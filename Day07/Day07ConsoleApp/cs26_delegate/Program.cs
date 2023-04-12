using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cs26_delegate.Calc;

namespace cs26_delegate
{
    // 대리 표현자를 사용하겠다는 선언
    delegate int CalcDelegate(int a, int b);

    delegate int Compare(int a, int b);

    #region<대리자 기본>
    class Calc
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        // static이 붙으면 무조건 실행될때 최초 메모리에 올라감
        // 프로그램 실행중에는 언제든지 접근가능
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
    #endregion
    internal class Program
    {

        // 오름차순 비교
        static int AscendCompare(int a, int b) 
        { 
            if (a>b) return 1;
            else if (a == b) return 0;
            else return -1;
        }

        // 내림차순 비교
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;
            else if (a == b) return 0;
            else return -1;
        }


        // 오름차순, 내림차순 정렬하나의 메서드에 실행가능
        static void BubbleSort(int[] DataSet, Compare comparer)
        {
            int i = 0, j = 0, temp = 0;
            for(i=0;i<DataSet.Length; i++) 
            {
                for (j = 0; j < DataSet.Length - i - 1; j++)
                {
                    if (comparer(DataSet[j], DataSet[j+1]) > 0) // 대리자 사용
                    {
                        temp = DataSet[j+1];
                        DataSet[j+1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            #region < 대리자 기본 예 > 
            // 일반적인 클래스 사용법 - 직접호출
            Calc normalCalc = new Calc();
            int x = 10, y = 15;
            int res = normalCalc.Plus(x, y);
            Console.WriteLine(res);
            Console.WriteLine(normalCalc.Plus(x, y));

            res = Calc.Minus(x, y);

            // 대리자를 사용하는 방식 - 대리자 대신 실행
            x = 30; y = 20;
            Calc delCale = new Calc();
            CalcDelegate Callback;

            Callback = new CalcDelegate(delCale.Plus);
            int res2 = Callback(x, y); // = Calc.Plus() 대신 호출
            Console.WriteLine(res2); // 50

            Callback = new CalcDelegate(Calc.Minus);    
            res2 = Callback(x, y);  
            Console.WriteLine(res2); // 10

            #endregion
            int[] origin = { 4, 7, 8, 2, 9, 1 };
            Console.WriteLine("오름차순 버블정렬");
            BubbleSort(origin, new Compare(AscendCompare));

            foreach(var item in origin)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();

            Console.WriteLine("내림차순 버블정렬");
            BubbleSort(origin, new Compare(DescendCompare));
            foreach (var item in origin)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();


        }
    }
}
