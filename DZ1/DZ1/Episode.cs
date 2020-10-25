using System;
using System.Collections.Generic;
using System.Text;

namespace DZ1
{
    public class Episode
    {
        private int viewers;
        private double gradesSum;
        private double maxGrade;
        public static Random generator;

        public Episode(int Viewers,double GradesSum, double MaxGrade)
        {
            viewers = Viewers;
            gradesSum = GradesSum;
            maxGrade = MaxGrade;
        }
        public Episode(): this(0,0,0) { }

        public static double GenerateRandomScore()
        {
            generator = new Random();
            double a;
            return a = generator.NextDouble()*10;
        }
        public double GetMaxScore()
        {
            return maxGrade;
        }
        public void AddView(double a)
        {
            viewers++;
            gradesSum+=a;
            if (maxGrade < a)
                maxGrade = a;
        }
        public double GetAverageScore()
        {
            return gradesSum / ((double)viewers);
        }
        public int GetViewerCount()
        {
            return viewers;
        }
     
    }
}
