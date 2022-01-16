using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator
{
    internal class gpaCal
    {
        private string name;
        private double score = 0;
        private SortedList<double, string> sortlist = new SortedList<double, string>();
        private double min = 0;
        private double max = 0;
        private double gpa = 0;

        public void getScore(string name, double score)
        {
            this.name = name;
            this.score = score;
            sortlist.Add(score, name);
        }

        public double getGpa()
        {
            double sum = 0;
            for (int i = 0; i < sortlist.Count; i++)
            {
                sum = sum + sortlist.Keys[i];
            }
            gpa = sum / sortlist.Count;
            return gpa;
        }

        public double getMinScore()
        {
            min = sortlist.Keys.Min();
            Console.WriteLine(min);
            return min;
        }

        public double getMaxScore()
        {
            max = sortlist.Keys.Max();
            Console.WriteLine(min);
            return max;
        }

        public string getMinName()
        {
            string minName = sortlist.Values.First();
            return minName;
        }

        public string getMaxName()
        {
            string maxName = sortlist.Values.Last();
            return maxName;
        }
    }
}
