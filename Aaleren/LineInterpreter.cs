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
        private static int variableIndex = 0;
        public void Init()
        {
            for(int i = 0; i < lines.Length; i++)
            {
                ManageConditions(i);
            }
            Console.WriteLine($"Empty lines: {emptyLines}, var[0]: {variables[0]}");
        }
        //TODO
        private void ManageConditions(int index)
        {
            //Line is empty
            if(!LineIsEmpty(index) && emptyLines % 5 == 0 && emptyLines > 0)
            {
                variables[variableIndex]++;
                Console.WriteLine(variables[variableIndex]);
            }
        }
        private bool LineIsEmpty(int index)
        {
            string[] wordsInLine = Editor.GetWordsInLine(index);
            if (wordsInLine[0] == "" && Editor.GetWordsInLine(index).Length == 1)
            {
                Console.WriteLine($"wordsInLine {index}: {Editor.GetWordsInLine(index).Length}");
                emptyLines++;
                return false;
            }

            return wordsInLine[0].ToUpper() == "AAL";
        }

        //Increments variableIndex, if its over the range (10),
        //it'll be set to 0 again
        private void IncrementVariableIndex()
        {
            if(variableIndex >= 10)
            {
                variableIndex = 0;
            }
            else
            {
                variableIndex++;
            }
        }
        private void IncrementVariableIndex(int count)
        {
            if (variableIndex + count >= 10)
            {
                variableIndex = 0;
            }
            else
            {
                variableIndex += count;
            }
        }


        /*
         * Wenn eine Zeile im Text leer ist / Empty space in the editor
                if(Editor.GetLines()[i].Length == 0)
                {
                    Console.WriteLine("Empty Line");
                }
        */
    }
}
