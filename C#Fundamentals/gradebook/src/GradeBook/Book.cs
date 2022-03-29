using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void CalculateStatistics(double grade)
    {
      var result = 0.0;
      var average = double.MinValue;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;
      
      foreach(var number in grades) 
        {
          if(number > highGrade){
              highGrade = number;
          }
          if(number < lowGrade){
              lowGrade = number;
          }
          result += number;
        }
    
      average = result / grades.Count;
    }

    public void ShowStatistics()
    {
      var result = 0.0;
      var average = double.MinValue;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;
      
      foreach(var number in grades) 
        {
          if(number > highGrade){
              highGrade = number;
          }
          if(number < lowGrade){
              lowGrade = number;
          }
          result += number;
        }
    
      average = result / grades.Count;
      Console.WriteLine($"You Highest Grade was {highGrade:N1}");

      Console.WriteLine($"You Lowest Grade was {lowGrade:N1}");

      Console.WriteLine($"The Average Grade is {average:N1}");
    }

    private List<double> grades;
    private string name;
  }
}