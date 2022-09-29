using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aaleren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LineInterpreter lineInterpreter = new LineInterpreter();
            lineInterpreter.Init();
            Console.ReadKey();
        }
    }
}
