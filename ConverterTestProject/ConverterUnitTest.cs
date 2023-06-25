using ConverterProject;
using System.Reflection;
using Xunit;

namespace ConverterTestProject
{
    public class ConverterUnitTest : IDisposable
    {

        private ConverterService converterService = new ConverterService();

        //[Fact]
        //public void ConvertCeliciusToFirenhait_0_32()
        //{
        //          // Arrange
        //          var expected = 32;
        //          var converterService = new ConverterService();

        //          // Act
        //          var actual = converterService.ConvertCeliciusToFirenhait(0);

        //          // Assert
        //          Assert.Equal(expected, actual);
        //}

        //      [Fact]
        //      public void ConvertCeliciusToFirenhait_m10_14()
        //      {
        //          // Arrange
        //          var expected = 14;
        //          var converterService = new ConverterService();

        //          // Act
        //          var actual = converterService.ConvertCeliciusToFirenhait(-10);

        //          // Assert
        //          Assert.Equal(expected, actual);
        //      }


        [Theory]
        [InlineData(0, 32)]
        [InlineData(-10, 14)]
        public void ConvertCeliciusToFirenhait(float value, float expected)
        {
            // Arrange
            //var converterService = new ConverterService();

            // Act
            var actual = converterService.GetFernhaitFromCelcius(value);

            // Assert
            Assert.Equal(expected, actual); 
        }

        [Theory]
        [InlineData(0, -17.8)]
        [InlineData(2, -16.7)]
        public void ConvertFeranhaitToCilcius(double value, double expected)
        {
            //Arrange
           // ConverterService converterService = new ConverterService();

            //Act
            var actual = converterService.GetCelciusFromFernhait(value);

            //Assert
            Assert.Equal(actual, expected, 1);

        }


        [Theory]
        [ClassData(typeof(Celcius))]
        public void TestEnumeratorWithTheory(float value, float expected)
        {
            // Arrange


            //Act
            var actual = converterService.GetCelciusFromFernhait(value);

            //Assert
            Assert.Equal(actual, expected, 1);

        }


        //[Theory]
        //[MemberData(nameof(GetFernahait))]
        //public void MyTestMethod()
        //{
        //    // Arrange


        //    // Act


        //    // Assert

        //}


        public void Dispose()
        {
            //Nettoyage des ressources de la classe
        }
    }
}