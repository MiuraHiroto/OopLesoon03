using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {

        //3.2.4
        static void Main(string[] args)
        {

            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };

            var nameCounts = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var length in nameCounts)
            {
                Console.WriteLine(length);
            }



            #region 3.2.3
            /*var selected = names.Where(s => s.Contains('o')).ToArray();
            foreach (var name in selected)
            {
                Console.WriteLine(name);
            }*/
            #endregion

            #region 3.2.2
            Console.Write("都市名を入力してください：");
            var count = names.Count(s => s.Contains('o'));
            Console.WriteLine(count);
            #endregion

            #region 3.2.1
            /*Console.Write("都市名を入力してください：");
            do
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }
                var findIndex = names.FindIndex(n => n == line);
                Console.WriteLine(findIndex);
            } while (true);*/
            #endregion
        }
    }
}
