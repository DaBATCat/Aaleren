using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aaleren
{
    internal class LineInterpreter
    {
        private string[] lines = Editor.GetLines();
        private int emptyLines = 0;
        private static int[] variables = new int[10];
        private char[] chars = new char[variables.Length];
        public void Init()
        {
            for(int i = 0; i < lines.Length; i++)
            {
                ManageConditions(i);
                //Console.WriteLine($"Length in Line {i+1}: " + Editor.GetWordsInLine(i).Length + $"\nemptyLines: {emptyLines}]");    
            }
        }
        //TODO
        private void ManageConditions(int index)
        {
            FirstWordIsAal(index);
            if(emptyLines % 5 == 0 && emptyLines > 0)
            {
                Console.WriteLine("Miau");
                variables[0]++;
                Console.WriteLine(variables[0]);
            }
        }
        private bool FirstWordIsAal(int index)
        {
            string[] wordsInLine = Editor.GetWordsInLine(index);
            if (wordsInLine[0] == "")
            {
                emptyLines++;
                //Console.WriteLine("EMPTY LINE");
            }

            return wordsInLine[0].ToUpper() == "AAL";
        }

        private bool CheckLinesEmpty() => emptyLines % 5 == 0;
        
        /*
         * Wenn eine Zeile im Text leer ist / Empty space in the editor
                if(Editor.GetLines()[i].Length == 0)
                {
                    Console.WriteLine("Empty Line");
                }
        */
    }
}
