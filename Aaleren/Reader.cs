using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aaleren
{
    internal class Reader
    {
        private StreamReader sr;
        private string path;
        private string[] lines;
        public Reader(string path)
        {
            this.path = path;
            sr = new StreamReader(path);
            
            int i = 0;
            lines = new string[] { };
            while (sr.ReadLine() != null)
            {
                lines[i] = sr.ReadLine();
                i++;
            }

        }

        public string[] Lines() => lines;
        public string Lines(int index)
        {
            return lines[index];
        }
        public int NumberOfLines()
        {
            int num = 0;
            while (sr.ReadLine() != null)
            {
                num++;
            }
            return num;
        }
        public void Close() { sr.Close(); }

        public string ReadLine(int index)
        {
            return lines[index];
        }
    }
}
