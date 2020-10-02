using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.2.1
            //var datas = new int[] { 1, 2, 3, 4, 5, 6, };
            var ymCollection = new YearMonth[]
            {
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2000,7),
                new YearMonth(2010,9),
                new YearMonth(2020,12),
            };
            //4.2.2
            Console.WriteLine("--4.2.2--");
            Exercise2_2(ymCollection);
            Console.WriteLine("---------\n");
            //4.2.3
            /*Console.WriteLine("--4.2.3--");
            Console.WriteLine(FindFirst21C(ymCollection));
            Console.WriteLine("---------\n");*/
            //4.2.4
            Console.WriteLine("--4.2.3--");
            Exercise2_4(ymCollection);
            Console.WriteLine("---------\n");
            //4.2.5
            Console.WriteLine("--4.2.5--");
            Exercise2_5(ymCollection);
            Console.WriteLine("---------\n");


        }
        private static void Exercise2_2(YearMonth[] ymCollection)
        {
            foreach (var ym in ymCollection)
            {
                Console.WriteLine(ym);
            }
        }
        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms)
        {
            foreach (var ym in yms)
            {
                //21世紀ならreturnして終了
                if (ym.Is21Century)
                    return ym;
            }
            return null;
        }
        //4.2.4
        private static void Exercise2_4(YearMonth[] ymCollection)
        {
            var yearmonth = FindFirst21C(ymCollection);
#if true
            var s = yearmonth == null ? "21世紀のデータはありません" : yearmonth.ToString();
            Console.WriteLine(s);
#endif
        }
        //4.2.5
        private static void Exercise2_5(YearMonth[] ymCollection)
        {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in array)
            {
                Console.WriteLine(ym);
            }
        }
    }
}
