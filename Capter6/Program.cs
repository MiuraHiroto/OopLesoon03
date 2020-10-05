﻿using Chapter06;
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

            var books = Books.GetBooks();
            Console.WriteLine($"本の平均価格:{ books.Average(x => x.Price)}");
            Console.WriteLine($"本の合計価格:{ books.Sum(x => x.Price)}");
            Console.WriteLine($"本のページが最大:{ books.Max(x => x.Pages)}");
            Console.WriteLine($"本の価格最大:{ books.Max(x => x.Price)}");
            Console.WriteLine($"タイトルに「物語」がある冊数:{ books.Count(x => x.Title.Contains("物語"))}");
        }
    }
}
