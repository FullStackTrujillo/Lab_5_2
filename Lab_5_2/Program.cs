using System;
using System.Collections.Generic;

namespace Lab_5_2
{
    class Program 
    {

        public enum WeekDays {
        
        Monday,
        Tuesday,
        Wednesday,
        Thurday,
        Friday,
        Saturday,
        Sunday
    }
        static void Main(string[] args)
        {
            List<string> taskList = new List<string>();

            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("Enter a new task for " + day);
                string task = day + " : " + Console.ReadLine();
                taskList.Add(task);

            }

            foreach (string task in taskList)
            {
                Console.WriteLine(task);
            }
        }
    }
}