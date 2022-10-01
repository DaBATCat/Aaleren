using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aaleren
{
    public static class Editor
    {
        private static string editorName = "Input.txt";
        private static StreamReader sr = File.Exists(editorName) ? new StreamReader(editorName) : throw new Exception();
        private static string[] lines = File.ReadAllLines(editorName);
        private static int lengthOfLines;
        public static string[] GetLines() => lines;
        //public static string GetLine(int index) => lines[index];
        public static string[] GetWordsInLine(int index)
        {
            if(lines[index] == "")
            {
                //Console.WriteLine($"detected NULL at {index}");
                return new string[] {""};
            }
            else return Tools.SplittedWords(lines[index]);
        }
    }
}
