using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public static class Sequences
    {
        public static void DisplaySequence_ForEach(IEnumerable<string> strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        //Display only N items
        public static void DisplayFirstN_ForEach(IReadOnlyList<string> strings, int maxToDisplay)
        {
             foreach (string s in strings.Take(maxToDisplay))
            {
                Console.WriteLine(s);
            }
        }

        public static void DisplayListWithIndex_ForEach(IReadOnlyList<string> strings)
        {
            int index = 1;

            foreach (string s in strings)
            {
                Console.WriteLine($"{index++} : {s}");
            }

        }

        //Display sequence with index
        public static void DisplayListWithIndex_For(IReadOnlyList<string> strings)
        {
            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine($"{i+1} : {strings[i]}");
            }
        }

        public static void DisplaySequence_For(IReadOnlyList<string> strings)
        {
            for (int i = 0; i < strings.Count; i++) {
                Console.WriteLine(strings[i]);
            }
        }

        public static void DisplayFirstN_For(IReadOnlyList<string> strings, int maxToDisplay)
        {
            for(int i = 0;i < strings.Count && i < maxToDisplay;i++) {
                Console.WriteLine(strings[i]);}
        }
    }
}
