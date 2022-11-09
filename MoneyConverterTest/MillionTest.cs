
using MoneyConverter.Core;

namespace MoneyConverterTest
{
    public class MillionTest
    {
        [Fact]
        public void Million_7_and_8_Digits()
        {
            // Arrange
            var thousand = new Millions(1_000_000);
            var thousand2 = new Millions(10_000_000);

            // Act
            var result = thousand.ConvertToWord();
            var result2 = thousand2.ConvertToWord();

            // Assert
            Assert.True(result == "One Million");
            Assert.True(result2 == "Teen Million");
        }



        [Fact]
        public void Million_8_and_9_Digits()
        {
            // Arrange
            var thousand = new Millions(12_011_123);
            var thousand2 = new Millions(561_000_109);

            // Act
            var result = thousand.ConvertToWord();
            var result2 = thousand2.ConvertToWord();

            // Assert
            Assert.True(result == "Twelve Million Eleven Thousand One Hundred and Twenty-Three");
            Assert.True(result2 == "Five Hundred and Sixty-One Million One Hundred and Nine");
        }

    }
}