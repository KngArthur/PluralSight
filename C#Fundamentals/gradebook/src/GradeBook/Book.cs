using System;
using System.Collections.Generic;
using System.IO;

namespace GradeBook
{

  public delegate void GradeAddedDelegate(object sender, EventArgs args);


  public class NamedObject
  {
    public NamedObject(string name)
    {
      Name = name;
    }

    public string Name
    {
      get;
      set;
    }
  }

  public interface IBook
  {
    void AddGrade(double grade);
    Statistics GetStatistics();
    string Name {get;}
    event GradeAddedDelegate GradeAdded;
  }

  public abstract class Book : NamedObject, IBook
  {
    protected Book(string name) : base(name)
    {
    }

    public abstract event GradeAddedDelegate GradeAdded;
    public abstract void AddGrade(double Grade);
    public abstract Statistics GetStatistics();
  }

  public class InMemoryBook : Book, IBook
  {
    public InMemoryBook(string name) : base(name)
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

        public class DiskBook : Book
        {
            public DiskBook(string name) : base(name)
            {
            }

            public override event GradeAddedDelegate GradeAdded;

            public override void AddGrade(double grade)
            {
                using(var writer = File.AppendText($"{Name}.txt"))
                {
                  writer.WriteLine(grade);
                  if(GradeAdded != null)
                  {
                    GradeAdded(this, new EventArgs());
                  }
                }
            }

            public override Statistics GetStatistics()
            {
                throw new NotImplementedException();
            }
        }

        public override void AddGrade(double grade)
    {
      if(grade <= 100 && grade >= 0)
      {
        grades.Add(grade);
        // method to invoke grade added delegate
        if(GradeAdded != null)
        { 
          GradeAdded(this, new EventArgs());
        }
      }
      else
      {
        throw new ArgumentException($"invalid {nameof(grade)}");
      }
    }

    public override event GradeAddedDelegate GradeAdded;

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

    public override Statistics GetStatistics()
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
    
    public const string CATEGORY = "Science";
  }
}