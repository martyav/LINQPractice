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

        public static bool AnyCapitals(String text)
        {
            var foundACapital = text.Any(x => Char.IsUpper(x));

            return foundACapital;
        }

        public static bool AllCapitals(String text)
        {
            List<char> foundLetters = text.Where(x => Char.IsLetter(x)).ToList();
            
            if (foundLetters == null || foundLetters.Count == 0)
            {
                return false;
            }

            var foundAllCaps = foundLetters.All(x => Char.IsUpper(x));

            return foundAllCaps;
        }
    }
}
