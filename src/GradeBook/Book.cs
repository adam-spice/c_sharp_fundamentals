using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name;
        private double result;
        public Book(string name)
        {
            this.grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public string GetName()
        {
            return Name;
        }

        public Stats GetStats()
        {
            var result = new Stats();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            foreach (double grade in this.grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= this.grades.Count;
            return result;

        }




    }
}