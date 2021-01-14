using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTimeRecord.Miller
{
    internal class DailyRecords
    {
        public void Display()
        {
            string pathFinder = @"C:\Users\johnv\Documents\DTR.csv";
            
            DailyTimeRecords(pathFinder);
        }
        public void DailyTimeRecords(string path)
        {
            
            try
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    Console.WriteLine(line + "\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
