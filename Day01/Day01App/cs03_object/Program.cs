using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs03_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Object type
            //// int == System.Int32
            //// long ==  Systme.Int64

            //long val = 1111;
            //long idata = 1024;
            //Console.WriteLine(idata);
            //Console.WriteLine(idata.GetType());
        
            //object iobj = (object)idata; // boxing : 데이터타입 값을 Object로 담아라
            //Console.WriteLine(iobj);
            //Console.WriteLine(iobj.GetType());

            //long udata = (long)iobj; // unboxing : object를 원래 데이터타입으로 바꿔라
            //Console.WriteLine(udata);
            //Console.WriteLine(udata.GetType());

            //double ddata = 3.141592;
            //object pobj = (object)ddata;
            //double pdata = (double)pobj;

            //Console.WriteLine(pobj);
            //Console.WriteLine(pobj.GetType());
            //Console.WriteLine(pdata);
            //Console.WriteLine(pdata.GetType());

            //short sdata = 32000;
            //int indata = sdata;
            //Console.WriteLine(indata);
            
            //long lndata = long.MaxValue;
            //Console.WriteLine(lndata);
            //indata = (int)lndata; // overflow
            //Console.WriteLine(indata);

            // float double 간 형 변환
            float fval = 3.141592f; // float형은 마지막에 f 써줘야함
            Console.WriteLine("fval="+fval);
            double dval = (double)fval;
            Console.WriteLine("dval="+dval);
            Console.WriteLine(fval == dval);
            Console.WriteLine(dval == 3.141592);

            // Very Important!!
            int numival = 1024;
            string strival = numival.ToString();
            //Console.WriteLine(numival == strival);
            Console.WriteLine(strival.GetType());

            // 문자열을 숫자로
            // 문자열내에 숫자가 아닌 특수문자나 정수인데 .이 있거나
            string originstr = "3000000"; // "3million" 은 예외발생
            int convval = Convert.ToInt32(originstr); // int Parse() 발생
            Console.WriteLine(convval);
            originstr = "1.2345";
            float convfloat = float.Parse(originstr);   
            Console.WriteLine(convfloat);
            // 예외발생하지 않도록 형변환 방법
            originstr = "120.0f";
            float ffval;
            // TryParse는 값이 예외가 발생하면 값은 0으로 대체
            float.TryParse(originstr, out ffval); // 예외발생하지 않게 숫자 변환
            Console.WriteLine(ffval);

            const double pi = 3.14159265358979;
            Console.WriteLine(pi);

            //pi = 4.56; 상수는 못바꿔용
        }
    }
}
