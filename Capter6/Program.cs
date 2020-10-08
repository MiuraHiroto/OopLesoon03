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
            /*var numbers = Enumerable.Range(1, 20).ToArray();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }*/

            var numbers = new List<int> { 9, 7, -5, 4, 2, 5, -4, 0, 4, -1, 0, 4, };
            Console.WriteLine($"平均値:{numbers.Average()}");
            Console.WriteLine($"合計値:{numbers.Sum()}");
            Console.WriteLine($"最小値:{numbers.Where(n => n > 0 ).Min()}");
            Console.WriteLine($"最大値:{numbers.Max()}");

            bool exists = numbers.Any(n => n % 7 == 0);
            
            var results = numbers.Where(n => n > 0).Take(3);
            foreach (var result in results)
            {
                Console.WriteLine(result + " ");
            }


            var books = Books.GetBooks();
            Console.WriteLine($"本の平均価格:{ books.Average(x => x.Price)}");
            Console.WriteLine($"本の合計価格:{ books.Sum(x => x.Price)}");
            Console.WriteLine($"本のページが最大:{ books.Max(x => x.Pages)}");
            Console.WriteLine($"本の価格最大:{ books.Max(x => x.Price)}");
            Console.WriteLine($"タイトルに「物語」がある冊数:{ books.Count(x => x.Title.Contains("物語"))}");

            //600ページを超える書籍はあるかないか？(Any)
            Console.WriteLine("\n600ページを超える書籍は");
            Console.WriteLine(books.Any(n => n.Pages > 600) ? "ある" : "ない");
            /*bool exit = books.Any(n => n.Pages >= 600);
            if (exit)
            {
                Console.WriteLine("ある");
            } else
            {
                Console.WriteLine("ない");
            }*/
            //すべてが200ページ以上の書籍か？(All)
            Console.WriteLine("\nすべてが200ページを超える書籍は");
            Console.WriteLine(books.All(x => x.Pages > 200) ? "200ページ以上" : "200ページ以下");
            //400ページを超える本は何冊目か？(FirstOrDefaultメソッド)
            //var book = books.FirstOrDefault(x => x.Pages > 400);
            /*int i;
            for ( i = 0; i < books.Count; i++)
            {
                if (books[i].Title.Contains(book.Title))
                {
                    break;
                }
            }*/
            var count = books.FindIndex(x => x.Pages > 400);
            Console.WriteLine($"400ページを超える本は{count + 1}冊目です。");

            //本の値段が400円以上のものを3冊表示
            var counts = books.Where(x => x.Price >= 400).Take(3);
            foreach (var item in counts)
            {
                Console.WriteLine(item.Title + " ");
            }
        }
    }
}
