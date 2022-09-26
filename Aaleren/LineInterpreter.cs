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

            }
        }
        //TODO
        private void ManageConditions(int index)
        {

        }
        private bool FirstWordIsAal(int index)
        {
            string[] wordsInLine = Editor.GetWordsInLine(index);
            if (wordsInLine.Length == 0)
            {
                emptyLines++;
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
