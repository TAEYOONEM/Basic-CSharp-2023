using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf13_bookRentalShop.Helpers
{   
    internal class Commons
    {
        // 모든 프로그램상에서 다 사용가능
        // DB연결문자열은 여기서만 수정하면 됨
        public static readonly string ConnString = "Server=localhost;" +
                                                     "Port=3306;" +
                                                 "Database=bookrentalShop;" +
                                                      "Uid=root;" +
                                                      "Pwd=12345";
    }
}
