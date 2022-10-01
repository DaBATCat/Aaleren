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
            CheckCode();
            for (int i = 0; i < lines.Length; i++)
            {
                ManageConditions(i);
            }
            //Console.WriteLine($"Empty lines: {emptyLines}, Integer[{variableIndex}]: {variables[0]}");
        }
        //TODO: Simple mathematical operations
        private void ManageConditions(int index)
        {
            //Line is empty
            if(!LineIsEmpty(index) && emptyLines % 5 == 0 && emptyLines > 0)
            {
                variables[variableIndex]++;
                //Console.WriteLine(variables[variableIndex]);
            }
            //Aal frisst Plankton   command
            if (IsAalFrisstPlankton(index))
            {
                //Console.WriteLine($"Aal frisst plankton at line {index + 1}");
                IncrementVariableIndex();
                
            }
            //Aal schaut umher      command
            if (IsAalSchautUmher(index))
            {
                chars[variableIndex] = (char)variables[variableIndex];
                //Console.WriteLine($"chars[{variableIndex}] = '{chars[variableIndex]}'");
            }
            //Aal macht Blubb       command with Console Write
            if (IsAalMachtBlubb(index))
            {
                foreach(char c in chars)
                {
                    Console.Write(c);
                }
            }
            //Aal schwurbelt        command with condition IsAalMachtBlubbAtLastLine()
            if (IsAalSchwurbelt(index))
            {
                if (IsAalMachtBlubbAtLastLine())
                {
                    variables[variableIndex] = 0;
                }
            }
        }
        private bool LineIsEmpty(int index)
        {
            string[] wordsInLine = Editor.GetWordsInLine(index);
            if (wordsInLine[0] == "" && Editor.GetWordsInLine(index).Length == 1)
            {
                //Console.WriteLine($"wordsInLine {index}: {Editor.GetWordsInLine(index).Length}");
                emptyLines++;
                return false;
            }

            return wordsInLine[0].ToUpper() == "AAL";
        }
        private bool IsAalFrisstPlankton(int lineIndex)
        {
            string[] wordsInLine = Editor.GetWordsInLine(lineIndex);
            if(wordsInLine.Length == 3)
            {
                if(wordsInLine[0].ToUpper() == "AAL" && wordsInLine[1].ToUpper() == "FRISST" &&
                    wordsInLine[2].ToUpper() == "PLANKTON")
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsAalSchautUmher(int lineIndex)
        {
            string[] wordsInLine = Editor.GetWordsInLine(lineIndex);
            if(wordsInLine.Length == 3)
            {
                if(wordsInLine[0].ToUpper() == "AAL" && wordsInLine[1].ToUpper() == "SCHAUT" &&
                    wordsInLine[2].ToUpper() == "UMHER")
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsAalMachtBlubb(int lineIndex)
        {
            string[] wordsInLine = Editor.GetWordsInLine(lineIndex);

            if (wordsInLine.Length == 3)
            {
                if (wordsInLine[0].ToUpper() == "AAL" && wordsInLine[1].ToUpper() == "MACHT" &&
                    wordsInLine[2].ToUpper() == "BLUBB")
                {
                    return true;
                }
            }
            
            return false;
        }
        private bool IsAalMachtBlubbAtLastLine()
        {
            string[] wordsInLastLine = Editor.GetWordsInLine(Editor.GetLines().Length - 1);

            if (wordsInLastLine.Length == 3)
            {
                if (wordsInLastLine[0].ToUpper() == "AAL" && wordsInLastLine[1].ToUpper() == "WIRD" &&
                    wordsInLastLine[2].ToUpper() == "GEGESSEN")
                {
                    return true;
                }
            }
            return false;

        }
        private bool IsAalSchwurbelt(int lineIndex)
        {
            string[] wordsInLine = Editor.GetWordsInLine(lineIndex);
            if (wordsInLine[0].ToUpper() == "AAL" && wordsInLine[1].ToUpper() == "SCHWURBELT")
            {
                return true;
            }
            return false;
        }


        //Increments variableIndex, if its over the range (10),
        //it'll be set to 0 again
        private void IncrementVariableIndex()
        {
            if(variableIndex >= variables.Length - 1)
            {
                variableIndex = 0;
            }
            else
            {
                variableIndex++;
            }
        }
        /*private void IncrementVariableIndex(int count)
        {
            if (variableIndex + count >= 10)
            {
                variableIndex = 0;
            }
            else
            {
                variableIndex += count;
            }
        }*/


        /*
         * Wenn eine Zeile im Text leer ist / Empty space in the editor
                if(Editor.GetLines()[i].Length == 0)
                {
                    Console.WriteLine("Empty Line");
                }
        */
        private void CheckCode()
        {
            if (!IsAalMachtBlubbAtLastLine())
            {
                ThrowHint("'Aal wird gegessen' is missing in the last line.");
            }
            for (int i = 0; i < lines.Length; i++)
            {
                if (IsAalSchwurbelt(i) && !IsAalMachtBlubbAtLastLine())
                {
                    ThrowHint($"Line {i + 1}: \"{lines[i]}\" This command is useless due to the " +
                        $"missing command 'Aal wird gegessen' in the last line.");
                }
            }
        }
        private void ThrowError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + msg);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Environment.Exit(0);
        }
        private void ThrowHint(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string emote = "/!\\";
            Console.WriteLine($"{emote} {msg}");
            Console.WriteLine("\\_/");
            Console.ForegroundColor = ConsoleColor.White;
            //Console.ReadKey();
        }
        
    }
}

/*To print out 'Hi':
 * 360 * Backspaces
 * Aal frisst Plankton
 * 525 * Backspaces
 * Aal frisst Plankton
 * Aal frisst Plankton
 * Aal frisst Plankton
 * Aal frisst Plankton
 * Aal frisst Plankton
 * Aal frisst Plankton
 * Aal frisst Plankton
 * Aal frisst Plankton
 * Aal frisst Plankton
 * Aal schaut umher
 * Aal frisst Plankton
 * Aal schaut umher
 */
