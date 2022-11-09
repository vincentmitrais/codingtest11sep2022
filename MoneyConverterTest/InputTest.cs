using System.Globalization;

namespace MoneyConverterTest
{
    public class InputTest
    {
        [Fact]
        public void Test_Input()
        {
            // Arrange
            var input = "193000000000916.91";
            decimal test = 193000000000916.91M;
            decimal convertResult = Convert.ToDecimal(input, new CultureInfo("en-US"));
            Int64 l1 = 193000000000916;

            Assert.True(test == convertResult);
        }



    }
}