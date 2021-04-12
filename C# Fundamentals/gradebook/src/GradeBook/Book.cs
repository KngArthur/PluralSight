using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
  {
    //Constructor
    public Book(string name)
    {
      this.name = name;
      grades = new List<double>();
    }

    public Statistics GetStatistics()
    {
      var result = new Statistics();
      result.Average = 0.0;
      result.High = double.MinValue;
      result.Low = double.MaxValue;

      foreach(double grade in grades)
      {
          result.Low = Math.Min(grade, result.Low);
          result.High = Math.Max(grade, result.High);
          result.Average += grade;
      }
      result.Average /= grades.Count;

      return result;
    }

    public void CalculateGrades()
    {
      
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }
    private List<double> grades;

    private string name;
  }
}