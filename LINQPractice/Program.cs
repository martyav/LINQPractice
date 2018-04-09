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

        public static int[] FindFirstArrayWithLength(List<int[]> list, int length)
        {
            int[] match = list.FirstOrDefault(x => x.Count() > length);

            return match;
        }

        public static int GetLastOddElement(int[] array)
        {
            int match = array.LastOrDefault(x => x % 2 != 0);

            return match;
        }

        public static int GetMaxStringLength(List<String> list)
        {
            int longest = list.Max(x => x.Count());

            return longest;
        }

        public static int GetMinListListValue(List<List<int>> listOLists)
        {
            var min = listOLists.Min(x => x.Min());

            return min;
        }

        public static List<User> sortUsersByAge(List<User> list)
        {
            var sortedByAgeAndName = list.OrderByDescending(x => x.Age).ThenBy(x => x.LastName);

            return sortedByAgeAndName.ToList();
        }

        public static String[] DoubleReverse(List<String> list)
        {
            var inenumerable = list as IEnumerable<String>;

            var reversed = inenumerable.Reverse();

            var reversedStrings = reversed.Select(x => new String(x.Reverse().ToArray()));

            return reversedStrings.ToArray();
        }
    }
}
