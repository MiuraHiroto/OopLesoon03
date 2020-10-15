using Chapter7s;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();
            Console.WriteLine("********************");
            Console.WriteLine("*辞書登録プログラム*");
            Console.WriteLine("********************");

            while (true)
            {
                Console.WriteLine("1.登録　2.内容を表示　3.終了");
                Console.Write(">");
                var n = Console.ReadLine();
                Console.WriteLine();
                if (n == "1")
                {
                    Console.Write("KEYを入力:");
                    var key = Console.ReadLine();
                    Console.Write("VALUEを入力:");
                    var value = Console.ReadLine();
                    Console.WriteLine("登録しました！");
                    // ディクショナリに追加
                    if (dict.ContainsKey(key))
                    {
                        dict[key].Add(value);
                    } else
                    {
                        dict[key] = new List<string> { value };
                    }
                }
                if (n == "2")
                {
                    // ディクショナリの内容を列挙
                    foreach (var item in dict)
                    {
                        foreach (var term in item.Value)
                        {
                            Console.WriteLine("{0} : {1}", item.Key, term);
                        }
                    }
                }
                if (n == "3")
                {
                    break;
                }
            }    
        }
    }
}
