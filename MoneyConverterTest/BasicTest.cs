
using MoneyConverter.Core;

namespace MoneyConverterTest
{
    public class Basci
    {
        [Fact]
        public void Basci_Number_Test()
        {
            // Arrange
            var basic1 = new Basics(1);
            var basic2 = new Basics(2);
            var basic3 = new Basics(3);
            var basic4 = new Basics(4);
            var basic5 = new Basics(5);
            var basic6 = new Basics(6);
            var basic7 = new Basics(7);
            var basic8 = new Basics(8);
            var basic9 = new Basics(9);

            // Act
            var result1 = basic1.ConvertToWord();
            var result2 = basic2.ConvertToWord();
            var result3 = basic3.ConvertToWord();
            var result4 = basic4.ConvertToWord();
            var result5 = basic5.ConvertToWord();
            var result6 = basic6.ConvertToWord();
            var result7 = basic7.ConvertToWord();
            var result8 = basic8.ConvertToWord();
            var result9 = basic9.ConvertToWord();

            // Assert
            Assert.True(result1 == "One");
            Assert.True(result2 == "Two");
            Assert.True(result3 == "Three");
            Assert.True(result4 == "Four");
            Assert.True(result5 == "Five");
            Assert.True(result6 == "Six");
            Assert.True(result7 == "Seven");
            Assert.True(result8 == "Eight");
            Assert.True(result9 == "Nine");


        }



    }
}