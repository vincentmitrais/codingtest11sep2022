
using MoneyConverter.Core;

namespace MoneyConverterTest
{
    public class BillionTest
    {
        [Fact]
        public void Billion_Siggle()
        {
            // Arrange
            var thousand = new Billions(1_000_000_000);
            var thousand2 = new Billions(19_000_000_000);
            var thousand3 = new Billions(193_000_000_916);

            // Act
            var result = thousand.ConvertToWord();
            var result2 = thousand2.ConvertToWord();
            var result3 = thousand3.ConvertToWord();

            // Assert
            Assert.True(result == "One Billion");
            Assert.True(result2 == "Nineteen Billion");
            Assert.True(result3 == "One Hundred and Ninety-Three Billion Nine Hundred and Sixteen");
        }



    }
}