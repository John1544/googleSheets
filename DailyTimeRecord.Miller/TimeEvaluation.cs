using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTimeRecord.Miller
{
    internal class TimeEvaluation
    {
        string fetchPath = @"C:\Users\johnv\Documents\DTR.csv";
        
        public void Display()
        {
            TimeRecords(fetchPath);
        }

        public void TimeRecords(string path)
        {
            TimeSpan totalTime = TimeSpan.Zero;
            int totalCount = 0;
            string[] unfilteredRecords = File.ReadAllLines(path);
            string[] timeStamps = unfilteredRecords.Where(a => a.ToLower().Trim() != "absent" && a.ToLower().Trim() != "no work").ToArray();

            foreach (string names in timeStamps)
            {
                string[] excludeName = names.Split('|').Where(a => !string.IsNullOrWhiteSpace(a)).ToArray();
                foreach (string timeLine in excludeName)
                {
                    string[] time = timeLine.Split('-');
                    TimeSpan total = TimeSpan.Parse(time[1]) - TimeSpan.Parse(time[0]);
                    totalTime += total;
                    totalCount++;
                }
            }

            string[] absencess = unfilteredRecords.Where(k => k.ToLower().Trim() == "absent").ToArray();
            Console.WriteLine($"Total time: {(int)totalTime.TotalHours}:{totalTime.Minutes}");
            Console.WriteLine($"Absencess: {absencess.Length}");
        }
    }
}