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
            #region iroiro
            /*var employeeDict = new Dictionary<int, Employee>()
            {
                {100,new Employee(100,"清水遼久")},
                {112,new Employee(112,"薪沢洋和") },
                {112,new Employee(125,"岩瀬奈央子") },
            };*/
            /*foreach (KeyValuePair<int,Employee> item in employeeDict)
            {
                Console.WriteLine($"{item.Value.Id} = {item.Value.Name}");
            }*/
            /*var flowerDict = new Dictionary<string, int>()
            {
                ["sunflower"] = 400,
                ["pansy"] = 300,
                ["tulip"] = 350,
                ["rose"] = 500,
                ["dahlia"] = 450,
            };*/
            //var employees = employeeDict.Where(emp => emp.Value.Id % 2 == 0).ToList();
            /*foreach (var item in employees)
            {
                Console.WriteLine($"{item.Value.Name}");
            }*/
            //Console.WriteLine($"{employeeDict.Sum(x => x.Value.Id)}");
            /*flowerDict["violet"] = 600;
            flowerDict.Add("violet", 700);
            */
            /*foreach (var item in flowerDict)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }*/
            #endregion
            #region employee
            /*var employee = new List<Employee>()
           {
               new Employee(100,"清水遼久"),
               new Employee(112,"薪沢洋和"),
               new Employee(125,"岩瀬奈央子"),
               new Employee(135,"沢城美由紀"),
               new Employee(107,"小早川紗枝"),
               new Employee(192,"泉こなた"),
               new Employee(123,"伊勢神宮"),
               new Employee(165,"花澤香菜"),
               new Employee(105,"村上優香理"),
           };*/
            //var employeeDict = employee.ToDictionary(emp => emp.Id );
            //偶数がIDのみディクショナリに変換する month;
            /*var employeeDict = employee.Where(emp => emp.Id % 2 == 0).ToDictionary(emp => emp.Id);
            foreach (KeyValuePair<int,Employee> item in employeeDict)
            {
                Console.WriteLine($"{item.Value.Id}{item.Value.Name}");
            }*/
            #endregion
            /*
            var dict = new Dictionary<MonthDay, string>
            {
                {new MonthDay(3,5),"珊瑚の日" },
                {new MonthDay(8,4),"箸の日" },
                {new MonthDay(10,3),"登山の日" },
            };

            var md = new MonthDay(8, 4);
            var s = dict[md];
            Console.WriteLine(s);
            */
            /*var lines = File.ReadAllLines("sample.txt");
            var we = new WordsExtractor(lines);
            foreach (var word in we.Extract())
            {
                Console.WriteLine(word);
            }*/
            DuplicateKeySample();
        }
        static public void DuplicateKeySample()
        {
            // ディクショナリの初期化
            var dict = new Dictionary<string, List<string>>() {
               { "PC", new List<string> { "パーソナル コンピュータ", "プログラム カウンタ", } },
               { "CD", new List<string> { "コンパクト ディスク", "キャッシュ ディスペンサー", } },
            };

            // ディクショナリに追加
            var key = "EC";
            var value = "電子商取引";
            if (dict.ContainsKey(key))
            {
                dict[key].Add(value);
            } else
            {
                dict[key] = new List<string> { value };
            }

            // ディクショナリの内容を列挙
            foreach (var item in dict)
            {
                foreach (var term in item.Value)
                {
                    Console.WriteLine("{0} : {1}", item.Key, term);
                }
            }
        }
    }
}
