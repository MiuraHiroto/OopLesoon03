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
            #region 6.1
            //var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35, };

            //6.1.1
            //Console.WriteLine(numbers.Max());
            //6.1.2
            /*var nums = numbers.Reverse().Take(2);
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }*/
            /*int pos = numbers.Length - 2;
            foreach (var number in numbers.Skip(pos))
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();*/
            //6.1.3
            /*numbers.Select(x => x.ToString()).ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();*/
            //6.1.4
            /*foreach (var item in numbers.OrderBy(n => n).Take(3))
            {
                Console.Write(item + " ");
            }*/
            //6.1.5
            //Console.WriteLine(numbers.Distinct().Count(n => n > 10));

            #endregion

            var books = new List<Book> {
                new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
                new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
                new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
                new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
                new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
                new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
                new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };
            //すべての書籍から「C#」の文字がいくつあるかをカウント
            int count = 0;

            foreach (var item in books.Where(b => b.Title.Contains("C#")))
            {
                for (int i = 0; i < item.Title.Length - 1 ; i++)
                {
                    if ((item.Title[i] == 'C')&&(item.Title[i + 1] == '#'))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"文字列「C#」の個数は{count}です。");

            //6.2.1
            var book = books.Where(x => x.Title == "C#プログラミングの新常識");
            /*if (book != null)
            {
                Console.WriteLine($"{book.Price}{book.Pages}");
            }*/
            foreach (var item in book)
            {
                Console.WriteLine($"価格:{item.Price}");
                Console.WriteLine($"ページ数:{item.Pages}");
            }
            //6.2.2
            Console.WriteLine(books.Count(x => x.Title.Contains("C#")));
            //6.2.3
            Console.WriteLine(books.Where(x => x.Title.Contains("C#")).Average(x => x.Pages ));
            //6.2.4
            //Console.WriteLine(books.FirstOrDefault(x => x.Price >= 4000));
           /* var booke = books.FirstOrDefault(b => b.Price >= 4000);
            if (booke != null)
            {
                Console.WriteLine(booke.Title);
            }*/
            //6.2.5
            var pages = books.Where(b => b.Price < 4000).Max();
            Console.WriteLine(pages);
            //6.2.6
            var selected = books.Where(b => b.Pages >= 400).OrderByDescending(b => b.Price);
            foreach (var item in selected)
            {
                Console.WriteLine("{0}{1}",item.Title,item.Price);
            }
            //6.2.7
            var selecte = books.Where(b => b.Title.Contains("C#") && b.Pages <= 500);
            foreach (var item in selecte)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
