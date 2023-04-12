﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_delegateChain
{
    delegate void ThereIsAFire(string location);    // 불났을 때 대신해주는 대리자

    delegate int Calc(int a, int b);

    delegate string Concatenate(string[] args);

    # region < 클래스 Sample 람다식 프로퍼티 >
    class Sample
    {
        private int valueA; // 멤버변수 - 외부에서 접근불가

        //private int ValueA // 프로퍼티
        //{
        //    //get { return valueA; }
        //    //set { valueA = value;}
        //    get => valueA;
        //    set => valueA = value;  
        //}

        public int ValueA
        {
            get => valueA;
            set {valueA = value;}
        }
    }
    #endregion

    internal class Program
    {
        static void Call119(string location)
        {
            Console.WriteLine("소방서죠! {0}에 불났어요!!", location);
        }
        static void ShoutOut(string location)
        {
            Console.WriteLine("{0}에 불났어요!", location);
        }
        static void Escape(string location)
        {
            Console.WriteLine("{0}에서 탈출합니다.", location);
        }

        static string ProConcate(string[] args)
        {
            string result = string.Empty; // =="";
            foreach(string s in args)
            {
                result += s + "/";
            }

            return result;
        }

        static void Main(string[] args)
        {
            #region< 대리자체인 영역 >
            //Console.WriteLine("--기본--");
            //var loc = "우리집";
            //Call119(loc);
            //ShoutOut(loc);
            //Escape(loc);

            //// 대리자
            //Console.WriteLine("\n--대리자(체인 연결)--");
            //var otherloc = "경찰서";
            //ThereIsAFire fire = new ThereIsAFire(Call119);
            //fire += new ThereIsAFire(ShoutOut);
            //fire += new ThereIsAFire(Escape);  // 대리자 메서드 연결(추가)
            //fire(otherloc);

            //Console.WriteLine("\n--대리자(체인 끊기)--");
            //fire -= new ThereIsAFire(Escape);   // 대리자 메서드 끊기(삭제)
            //fire("다른집");
            //Console.WriteLine();

            //// 익명함수
            //Calc plus = delegate (int a, int b)
            //{
            //    return a + b;
            //};
            //Console.WriteLine(plus(6, 7));

            //Calc minus = (a, b) => { return a - b; }; 
            //Console.WriteLine(minus(6, 7));

            //Calc simpleMinus = (a, b) => a - b; // 람다식
            #endregion

            Concatenate concat = new Concatenate(ProConcate);
            var result = concat(args);

            Console.WriteLine(result);

            Concatenate concat2 = (arr) =>
            {
                string res = string.Empty; // == ";
                foreach (string s in args)
                {
                    res += s + "/";
                }
                return res;
            };

        }
    }
}