using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aaleren
{
    public class EditorTools
    {
        private static string editorName = "Input.txt";
        private StreamReader sr = File.Exists(editorName) ? new StreamReader(editorName) : throw new Exception();
        private string[] lines, wordsInLine;
        private int lengthOfLines;
        public EditorTools()
        {

        }
        public string[] GetLines() => File.ReadAllLines(editorName);
        public string[] 
    }
}
