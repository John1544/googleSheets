using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DailyTimeRecord.Miller
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TimeEvaluation toAdd = new TimeEvaluation();

            toAdd.Display();
            Console.ReadLine();

        }
    }
}
