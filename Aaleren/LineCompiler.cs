using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aaleren
{
    internal class LineCompiler
    {
        private Reader r;
        private string line;

        public LineCompiler()
        {
            r = new Reader("Saas.txt");
        }

        public void GetInput()
        {
            for (int i = 0; i < r.NumberOfLines(); i++)
            {
                line = r.ReadLine(i);
                CheckInput(SplittedWordsInLine(line));
            }
        }

        private string[] SplittedWordsInLine(string line)
        {
            string[] res = line.Split(' ');
            return res;
        }
        private void CheckInput(string[] wordsInLine)
        {
            for (int i = 0; i < wordsInLine.Length; i++)
            {
                switch (wordsInLine[i])
                {
                    case "chicken":
                        if (Tools.AllStringsAreTheSame(wordsInLine))
                        {
                            
                        }
                        break;
                }
            }
        }
    }
}
