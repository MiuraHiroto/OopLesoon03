using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.1
            Console.Write("文字列1");
            var str1 = Console.ReadLine();
            Console.Write("文字列2");
            var str2 = Console.ReadLine();
            if (String.Compare(str1, str2, true) == 0)
                Console.WriteLine("等しい");
            else
                Console.WriteLine("等しくない");

            //5.2
            Console.Write("数値文字列:");
            var line = Console.ReadLine();
            int num;//変更後の数値格納用
           
            if (int.TryParse(line,out num))
            {
                Console.WriteLine(num.ToString("#,#"));
            } else
            {
                Console.WriteLine("数値文字列ではありません");
            }
        }       
    }
}
