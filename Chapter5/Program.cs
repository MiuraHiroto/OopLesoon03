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
            var s = "Jackdaws love my big sphinx of quartz";
            var lines = "Novelist=谷崎潤一郎;BestWork=春琴沙;Born=1886";
            #region 5.1
            //5.1
            /*Console.Write("文字列1");
            var str1 = Console.ReadLine();
            Console.Write("文字列2");
            var str2 = Console.ReadLine();
            if (String.Compare(str1, str2, true) == 0)
                Console.WriteLine("等しい");
            else
                Console.WriteLine("等しくない");
            */
            #endregion
            #region 5.2
            //5.2
            /*Console.Write("数値文字列:");
            var line = Console.ReadLine();
            int num;//変更後の数値格納用
           
            if (int.TryParse(line,out num))
            {
                Console.WriteLine(num.ToString("#,#"));
            } else
            {
                Console.WriteLine("数値文字列ではありません");
            }*/
            #endregion
            #region 5.3,5.4
            //5.3
            //5.3.1
            //Console.WriteLine(s.Count(c => c == ' '));
            //5.3.2
            /*string n = s.Replace("big", "small");
            Console.WriteLine(n);*/
            //5.3.3
           /* var count = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            //int count = text.Split('').count();
            Console.WriteLine(count);*/
            //5.3.4   
            /*s.Split(' ').Where(c => c.Length <= 4).ToList().ForEach(Console.WriteLine);//ラムダ式
            var words = s.Split(' ').Where(c => c.Length <= 4);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }*/
            //5.3.5
            /*var array = s.Split(' ').ToArray();
            if (array.Length > 0)
            {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1))
                {
                    sb.Append(' ');
                    sb.Append(word);
                }
                Console.WriteLine(sb);
            }*/
            #endregion

            //5.4
            //var word = line.Split(';');
            foreach (var line in lines.Split(';'))
            {
                var word = line.Split('=');
                Console.WriteLine("{0}:{1}", ToJapanese(word[0]), word[1]);
            }
        }
        static string ToJapanese(string key)
        {
            switch (key)
            {
                case "Novelist":
                    return "作家";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
                default:
                    return "      ";

            }
        }
    }
}
