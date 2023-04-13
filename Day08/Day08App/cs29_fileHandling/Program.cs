using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs29_fileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Diretory == Folder
            // "C:\\Dev" / @"C:\Dev" 리터럴은 여러줄 문자열도 가능
            string curDir = @"C:\Temp"; // C:\Dev 절대경로 

            Console.WriteLine("현재 디렉토리 정보");
        
            var dirs = Directory.GetDirectories(curDir);
            foreach(var dir in dirs)
            {
                var dirInfo = new DirectoryInfo(dir);

                Console.WriteLine(dirInfo.Name);
                Console.WriteLine(" [{0}]",dirInfo.Attributes);
            }
            Console.WriteLine("현재 디렉토리 파일 정보");

            var files = Directory.GetFiles(curDir);
            foreach(var file in files)
            {
                var fileInfo = new FileInfo(file);

                Console.Write(fileInfo.Name);
                Console.WriteLine(" [{0}]",fileInfo.Attributes);
            }

            // 특정 경로에 하위폴더/ 하위파일 조회

            string path = @"C:\Temp\CSharp_Bank2"; // 만들고자 하는 폴더 구분자로 / 도 가능
            string sfile = "Test2.log";

            if (Directory.Exists(path))
            {
                Console.WriteLine("경로가 존재하여 파일을 생성합니다/");
                File.Create(path + @"\" + sfile); // C:\Temp\CSharp_Bank\Test.log
            }
            else
            {
                Console.WriteLine($"해당 경로가 없습니다 {path}");
                Directory.CreateDirectory(path);

                Console.WriteLine("경로를 생성하여 파일을 생성합니다.");
                File.Create(path + @"\" + sfile);

            }

        }
    }
}
