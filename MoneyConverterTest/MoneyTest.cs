using MoneyConverter.Core.Extentions;

namespace MoneyConverterTest
{
    public class MoneyTest
    {
        [Fact]
        public void Billion_Siggle()
        {
            // Arrange
            var thousand = 1_000_000_000_000.90M;
            var thousand2 = 19_000_000_000_000M;
            var thousand3 = 193_000_000_000_916M;

            // Act
            var result = thousand.ConvertToWord();
            var result2 = thousand2.ConvertToWord();
            var result3 = thousand3.ConvertToWord();

            // Assert
            Assert.True(result == "One Trillion Dollars and Ninety Cents");
            Assert.True(result2 == "Nineteen Trillion Dollars");
            Assert.True(result3 == "One Hundred and Ninety-Three Trillion Nine Hundred and Sixteen Dollars");
        }


        [Fact]
        public void Basics_with_Cent()
        {
            var test1 = (12.67M).ConvertToWord();
            var test2 = (512.04M).ConvertToWord();
            var test3 = (3512.04M).ConvertToWord();
            var test4 = (893521.25M).ConvertToWord();


            // assert
            Assert.True(test1 == "Twelve Dollars and Sixty-Seven Cents");
            Assert.True(test2 == "Five Hundred and Twelve Dollars and Four Cents");
            Assert.True(test3 == "Three Thousand Five Hundred and Twelve Dollars and Four Cents");
            Assert.True(test4 == "Eight Hundred and Ninety-Three Thousand Five Hundred and Twenty-One Dollars and Twenty-Five Cents");
        }

    }
}