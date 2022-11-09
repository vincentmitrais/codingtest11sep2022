using MoneyConverter.Core.Interfaces;

namespace MoneyConverter.Core
{
    public class Dozens : INumberConverter
    {
        private List<NumberAndWord> Words = new List<NumberAndWord>() {
            new NumberAndWord(11, "Eleven"),
            new NumberAndWord(12, "Twelve"),
            new NumberAndWord(13, "Thirteen"),
            new NumberAndWord(14, "Fourteen"),
            new NumberAndWord(15, "Fifteen"),
            new NumberAndWord(16, "Sixteen"),
            new NumberAndWord(17, "Seventeen"),
            new NumberAndWord(18, "Eighteen"),
            new NumberAndWord(19, "Nineteen"),
        };


        private List<NumberAndWord> DozensPrefix = new List<NumberAndWord>
        {
            new NumberAndWord(10, "Teen"),
            new NumberAndWord(20, "Twenty"),
            new NumberAndWord(30, "Thirty"),
            new NumberAndWord(40, "Forty"),
            new NumberAndWord(50, "Fifty"),
            new NumberAndWord(60, "Sixty"),
            new NumberAndWord(70, "Seventy"),
            new NumberAndWord(80, "Eighty"),
            new NumberAndWord(90, "Ninety"),
        };


        public int Number { get; private set; }
        public Dozens(int number)
        {

            if (number < 0 && number > 99)
                throw new System.ArgumentOutOfRangeException("Input number is out of range. The number should >= 10 and number <= 99");

            Number = number;
        }

        public string ConvertToWord()
        {
            if (Number >= 11 && Number <= 19)
                return Words[Number - 11].Word;


            if (DozensPrefix.Where(x => x.Number == Number).Any())
                return DozensPrefix.Where(x => x.Number == Number).First().Word;


            var basicNumber = new Basics(Convert.ToInt32(Number.ToString().Substring(1, 1)));
            var selectedDozen = DozensPrefix.Where(x => x.Number == (Number - basicNumber.Number)).FirstOrDefault()?.Word;
            return $"{selectedDozen}-{basicNumber.ConvertToWord()}";
        }

    }
}
