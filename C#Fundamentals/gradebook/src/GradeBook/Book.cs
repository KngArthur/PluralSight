using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      Name = name;
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

    public Statistics GetStatistics()
    {
      var result = new Statistics();
      result.Average = 0.0;
      result.High = double.MinValue;
      result.Low = double.MaxValue;
      
      foreach(var grade in grades) 
        {
          if(grade > result.High){
              result.High = grade;
          }
          if(grade < result.Low){
              result.Low = grade;
          }
          result.Average += grade;
        }
    
      result.Average /= grades.Count;
      
      return result;
    }

    private List<double> grades;
    public string Name;
  }
}