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

    public void AddGrade(char letter)
    {
      switch(letter)
      {
        case 'A':
          AddGrade(90);
          break;

        case 'B':
          AddGrade(80);
          break;

        case 'C':
          AddGrade(70);
          break;
        
        case 'D':
          AddGrade(60);
          break;
        
        default:
          AddGrade(0);
          break;
      }
    }
    public void AddGrade(double grade)
    {
      if(grade <= 100 && grade >= 0)
      {
        grades.Add(grade);
      }
      else
      {
        throw new ArgumentException($"invalid {nameof(grade)}");
      }
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

      for(var index = 0; index < grades.Count; index += 1)    
        {
          result.Low = Math.Min(grades[index], result.Low);
          result.High = Math.Max(grades[index], result.High);
          result.Average += grades[index];
        }
    
      result.Average /= grades.Count;

      switch(result.Average)
      {
        case var d when d >= 90.0:
          result.Letter = 'A';
          break;

        case var d when d >= 80.0:
          result.Letter = 'B';
          break;

        case var d when d >= 70.0:
          result.Letter = 'C';
          break;

        case var d when d >= 60.0:
          result.Letter = 'D';
          break;

        default:
          result.Letter = 'F';
          break;
      }
      
      return result;
    }

    private List<double> grades;

    public string Name
    {
      get; 
      private set;
    }
    
    public const string CATEGORY = "Science";
  }
}