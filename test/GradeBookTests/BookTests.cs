using System;
using Xunit;
using GradeBook;

namespace GradeBookTests
{
 public class BookTests
    {
        [Fact]
        public void BookCalculateAverageGrade()
        {
            //Arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // Act
            var result = book.GetMaxMinGradeAvg();

            // Assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal (77.3, result.Low, 1);
        }


        [Fact]

        public void AddTest()
        {
            var book = new InMemoryBook("Test");
            
            book.AddGrade(110);
            book.AddGrade(0);
            var result1 = book.lgrades.Contains(110);
            var result2 = book.lgrades.Contains(0);
            Assert.False(result1);
            Assert.True(result2);

        }


    }
}