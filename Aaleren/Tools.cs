using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aaleren
{
    public static class Tools
    {
        private static Random rnd;
        //Gibt True zurück, wenn der Divisor
        //durch den Dividenten teilbar ist.
        public static bool IsDividedBy(int value, int divisor)
        {
            return value % divisor == 0;
        }
        /**public static bool IsDividedBy(double value, double divisor)
        {
            return value % divisor == 0.0;
        }**/
        public static void ColoredWriteLine(ConsoleColor color, string msg)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static int RandomInt(int bound)
        {
            rnd = new Random();
            return rnd.Next(bound);
        }
        public static int RandomInt(int start, int bound)
        {
            rnd = new Random();
            return rnd.Next(start, bound);
        }
        public static bool RandomBool()
        {
            var random = new Random();
            Task.Delay(5).Wait();
            return random.Next(2) == 1;
        }
        public static void Wait(int milisec) { Task.Delay(milisec).Wait(); }
        public static string[] SplittedWords(string input, char splitChar)
        {
            string[] res = input.Split(splitChar);
            return res;
        }
        public static string[] SplittedWords(string input)
        {
            string[] res = input.Split(' ');
            return res;
        }
        public static bool AllStringsAreTheSame(string[] words)
        {
            string word = words[0];

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != word) return false;
            }
            return true;
        }

    }
}

