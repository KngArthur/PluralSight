using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
  {
    //Constructor
    public Book(string name)
    {
      this.name = name;
      grades = new List<double>();
    }

    public void ShowStatistics()
    {
      var result = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;

      foreach(double number in grades)
      {
          result += number;
          if(number > highGrade) {
              highGrade = number;
          }
          // Or could be
          lowGrade = Math.Min(number, lowGrade);
      }
      var averageGrade = result / grades.Count;

      Console.WriteLine($"The Highest Grade was {highGrade}.");
      Console.WriteLine($"The Lowest Grade Was {lowGrade}.");
      Console.WriteLine($"The Average Grade is {averageGrade:N2}.");
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