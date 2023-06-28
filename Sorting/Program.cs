using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Task1
            var intList = new List<int>{ 1, 6, -85, 934, -80, 12, -3, 2, 549, 28 };

            PrintList(intList);

            intList.Sort();
            PrintList(intList);

            PrintList(intList.Where(x => x % 2 == 0).ToList());

            PrintList(intList.Where(x => x > 42).ToList());

            Console.WriteLine(intList.Sum());

            ///Task2

            var stringList = new List<string> { "hgvh hvlhJh j", "dogHgv ", "jh3vggf", "TYF"};
            var str = "dog";

            PrintList(stringList);

            PrintList(stringList.Where(x => !x.Contains(" ")).ToList());

            PrintList(stringList.Where(x => x.ToLower()!=x).ToList());

            PrintList(stringList.Where(x => x.Contains(str)).ToList());

            Console.WriteLine(stringList.Any(x => x.Any(char.IsDigit)));
        }

        static void PrintList<T>(List<T> list)
        {
            list.ForEach(x => Console.Write("{0}|", x));
            Console.WriteLine();
        }
    }
}
