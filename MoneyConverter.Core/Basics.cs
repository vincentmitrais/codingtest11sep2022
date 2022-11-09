using MoneyConverter.Core.Interfaces;

namespace MoneyConverter.Core
{
    public class Basics : INumberConverter
    {
        private List<NumberAndWord> Words = new List<NumberAndWord>() {
            new NumberAndWord(1, "One"),
            new NumberAndWord(2, "Two"),
            new NumberAndWord(3, "Three"),
            new NumberAndWord(4, "Four"),
            new NumberAndWord(5, "Five"),
            new NumberAndWord(6, "Six"),
            new NumberAndWord(7, "Seven"),
            new NumberAndWord(8, "Eight"),
            new NumberAndWord(9, "Nine"),
        };

        public int Number { get; set; }

        public Basics(int number)
        {
            if (number < 0 && number > 9)
                throw new ArgumentOutOfRangeException("Input number is out of range. The number should > 0 and number <= 9");

            Number = number;
        }

        public string ConvertToWord() => Number == 0 ? null : Words[Number - 1].Word;

    }
}
