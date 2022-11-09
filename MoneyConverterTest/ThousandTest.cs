
using MoneyConverter.Core;

namespace MoneyConverterTest
{
    public class ThousandTest
    {
        [Fact]
        public void Thousand_4_Digits_Combine()
        {
            // Arrange
            var thousand = new Thousands(1_123);

            // Act
            var result = thousand.ConvertToWord();


            // Assert
            Assert.True(result == "One Thousand One Hundred and Twenty-Three");
        }


        [Fact]
        public void Thousand_4_Digits()
        {
            // Arrange
            var thousand = new Thousands(1_000);

            // Act
            var result = thousand.ConvertToWord();


            // Assert
            Assert.True(result == "One Thousand");
        }


        [Fact]
        public void Thousand_5_Digits()
        {
            // Arrange
            var thousand = new Thousands(500_001);

            // Act
            var result = thousand.ConvertToWord();


            // Assert
            Assert.True(result == "Five Hundred Thousand One");
        }


        [Fact]
        public void Thousand_5_Digits_Combine()
        {
            // Arrange
            var thousand = new Thousands(500_101);
            var thousand2 = new Thousands(501_101);

            // Act
            var result = thousand.ConvertToWord();
            var result2 = thousand2.ConvertToWord();


            // Assert
            Assert.True(result == "Five Hundred Thousand One Hundred and One");
            Assert.True(result2 == "Five Hundred and One Thousand One Hundred and One");
        }

    }
}