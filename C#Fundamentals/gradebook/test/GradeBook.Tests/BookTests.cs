using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        // [Fact]
        // public void OnlyValidGradeAccepted()
        // {
        //     var book = new Book("");
        //     book.AddGrade(105);
        //     Assert.

        // }

        // Delegate example

        public delegate string WriteLogDelegate(string logMessage);
        
        // Test for Delegate function
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log;

            log = new WriteLogDelegate(ReturnMessage);

            // Short hand for above is log = ReturnMessage

            var result = log("Hello!");
            Assert.Equal("Hello!", result);
        }

        int count = 0;

        string ReturnMessage(string message)
        {
            count ++;
            return message;
        }

        string IncrementCount(string message)
        {
            count ++;
            return message.ToLower();
        }

        // Test for Multiple Cast Delegate
        [Fact]
        public void WriteLogDelegateCanPointToMultipleMethod()
        {
            WriteLogDelegate log = ReturnMessage;

            log += ReturnMessage;
            log += IncrementCount;

            // Short hand for above is log = ReturnMessage

            var result = log("Hello!");
            Assert.Equal(3, count);
        }

        [Fact]
        public void BookCalculatesAverageGrade()
        {   
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }
    }
}
