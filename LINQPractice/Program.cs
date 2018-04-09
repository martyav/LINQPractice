using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static List<int> Increment(List<int> list)
        {
            var incrementedList = list.Select(x => x + 1);

            return incrementedList.ToList();
        }

        public static int[] GetWhereDivisible(List<int> list, int x)
        {
            var foundDivisible = list.Where(queried => queried % x == 0);

            return foundDivisible.ToArray();
        }
    }
}
