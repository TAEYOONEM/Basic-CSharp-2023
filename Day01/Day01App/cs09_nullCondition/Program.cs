using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs09_nullCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo myfoo = null;
            //myfoo.member = 30;

            //int? bar;
            //if(myfoo != null)
            //{
            //    bar = myfoo.member;
            //}
            //else
            //{
            //    bar = null;
            //}

            // 위의 주석줄을 모두 축약시킴
            int? bar = myfoo?.member;
        }
    }
}

class Foo {
    public int member;
}
