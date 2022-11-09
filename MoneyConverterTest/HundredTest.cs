
using MoneyConverter.Core;

namespace MoneyConverterTest
{
    public class HundredTest
    {
        [Fact]
        public void Hudred_Return_True()
        {
            // Arrange
            var number = 123;
            var hundred = new Hundreds(number);

            // Act
            var result = hundred.ConvertToWord();


            // Assert
            Assert.True(result == "One Hundred and Twenty-Three");
        }


        [Fact]
        public void Hudred_Basics_Return_True()
        {
            // Arrange
            var hundred = new Hundreds(103);
            var hundred1 = new Hundreds(100);

            // Act
            var result = hundred.ConvertToWord();
            var resul1 = hundred1.ConvertToWord();

            // Assert
            Assert.True(result == "One Hundred and Three");
            Assert.True(resul1 == "One Hundred");
        }


        [Fact]
        public void Test_Big_Hundred()
        {
            // Arrange
            var hundred = new Hundreds(990);
            var hundred1 = new Hundreds(999);
            var hundred2 = new Hundreds(900);

            // Act
            var result = hundred.ConvertToWord();
            var resul1 = hundred1.ConvertToWord();
            var resul2 = hundred2.ConvertToWord();

            // Assert
            Assert.True(result == "Nine Hundred and Ninety");
            Assert.True(resul1 == "Nine Hundred and Ninety-Nine");
            Assert.True(resul2 == "Nine Hundred");
        }
    }
}