using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Capter6
{
    class Program
    {
        static void Main(string[] args)
        {
            //整数の例
            var numbers = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 12, 28, 19, 30, 24, };

            /*var strings = numbers.Distinct().Select(n => n.ToString("0000")).ToArray();
            foreach (var str in strings)
            {
                Console.WriteLine(str + " ");
            }*/

            numbers.Select(n => n.ToString("0000")).Distinct().ToList().ForEach(s => Console.Write(s + " "));
            //Console.WriteLine(); //改行
            //var sortedNumbers = numbers.OrderBy(n => n);
            //並べ替え
            Console.WriteLine(); //改行
            var sortedNumbers = numbers.OrderBy(n => n);
            foreach (var nums in sortedNumbers)
            {
                Console.Write(nums + " ");
            }

            //文字列
            var words = new List<string>
            {
                  "Microsoft","Apple","Google","Oracle","Facebook",
            };
            var lower = words.Select(name => name.ToLower().ToArray());

            //オブジェクトの例
            var books = Books.GetBooks();
            //タイトルリスト
            var titles = books.Select(name => name.Title);

            foreach (var title in titles)
            {
                Console.Write(title + " ");
            }
            //ページ数の多い順に並び替え(または金額の高い順)
            var booke = books.OrderByDescending(book => book.Pages).Take(3);
            foreach (var book in booke)
            {
                Console.WriteLine(book.Title + " " + book.Pages);
            }
            //var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35, };
            
        }
    }
}
