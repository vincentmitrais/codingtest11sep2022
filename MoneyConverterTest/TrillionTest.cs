
using MoneyConverter.Core;

namespace MoneyConverterTest
{
    public class TrillionTest
    {
        [Fact]
        public void Billion_Siggle()
        {
            // Arrange
            var thousand = new Trillions(1_000_000_000_000);
            var thousand2 = new Trillions(19_000_000_000_000);
            var thousand3 = new Trillions(193_000_000_000_916);

            // Act
            var result = thousand.ConvertToWord();
            var result2 = thousand2.ConvertToWord();
            var result3 = thousand3.ConvertToWord();

            // Assert
            Assert.True(result == "One Trillion");
            Assert.True(result2 == "Nineteen Trillion");
            Assert.True(result3 == "One Hundred and Ninety-Three Trillion Nine Hundred and Sixteen");
        }



    }
}