
using MoneyConverter.Core;

namespace MoneyConverterTest
{
    public class Dozons
    {
        [Fact]
        public void Dozens_Number_Test()
        {
            // Arrange
            var dozons1 = new Dozens(11);
            var dozons2 = new Dozens(12);
            var dozons3 = new Dozens(13);
            var dozons4 = new Dozens(14);
            var dozons5 = new Dozens(15);
            var dozons6 = new Dozens(16);
            var dozons7 = new Dozens(17);
            var dozons8 = new Dozens(18);
            var dozons9 = new Dozens(19);
            var dozons10 = new Dozens(20);
            var dozons11 = new Dozens(21);
            var dozons12 = new Dozens(32);
            var dozons13 = new Dozens(57);
            var dozons14 = new Dozens(69);
            var dozons15 = new Dozens(10);

            // Act
            var result1 = dozons1.ConvertToWord();
            var result2 = dozons2.ConvertToWord();
            var result3 = dozons3.ConvertToWord();
            var result4 = dozons4.ConvertToWord();
            var result5 = dozons5.ConvertToWord();
            var result6 = dozons6.ConvertToWord();
            var result7 = dozons7.ConvertToWord();
            var result8 = dozons8.ConvertToWord();
            var result9 = dozons9.ConvertToWord();
            var result10 = dozons10.ConvertToWord();
            var result11 = dozons11.ConvertToWord();
            var result12 = dozons12.ConvertToWord();
            var result13 = dozons13.ConvertToWord();
            var result14 = dozons14.ConvertToWord();
            var result15 = dozons15.ConvertToWord();


            // Assert
            Assert.True(result1 == "Eleven");
            Assert.True(result2 == "Twelve");
            Assert.True(result3 == "Thirteen");
            Assert.True(result4 == "Fourteen");
            Assert.True(result5 == "Fifteen");
            Assert.True(result6 == "Sixteen");
            Assert.True(result7 == "Seventeen");
            Assert.True(result8 == "Eighteen");
            Assert.True(result9 == "Nineteen");
            Assert.True(result10 == "Twenty");
            Assert.True(result11 == "Twenty-One");
            Assert.True(result12 == "Thirty-Two");
            Assert.True(result13 == "Fifty-Seven");
            Assert.True(result14 == "Sixty-Nine");
            Assert.True(result15 == "Teen");


        }



    }
}