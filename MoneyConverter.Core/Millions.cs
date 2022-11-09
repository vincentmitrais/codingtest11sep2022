using MoneyConverter.Core.Extentions;
using MoneyConverter.Core.Interfaces;

namespace MoneyConverter.Core
{
    public class Millions : INumberConverter
    {

        public int Number { get; set; }
        private string MaxDigitNumber { get; set; }
        private int MillionLevelNumber => Convert.ToInt32(MaxDigitNumber.Substring(0, 3));
        private int ThousandLevelNumber => Convert.ToInt32(MaxDigitNumber.Substring(3, 6));



        public Millions(int number)
        {
            if (number < 0 && number > 999_999_999)
                throw new System.ArgumentOutOfRangeException("Input number is out of range. The number should >= 1000000 and number <= 999999999");

            Number = number;
            MaxDigitNumber = $"000000000{Number}";
            MaxDigitNumber = MaxDigitNumber.Substring(MaxDigitNumber.Count() - 9, 9);
        }


        public string ConvertToWord()
        {
            var million = ConvertMillionToString();
            var thousand = ConvertThousandToString();
            return $"{million}{(thousand == null ? null : (million == null ? "" : " ") + thousand)}";
        }


        private string ConvertMillionToString()
        {
            if (MillionLevelNumber == 0)
                return null;

            var result = MillionLevelNumber.GenerateConverter3Digit()?.ConvertToWord();
            return result == null || result == string.Empty ? null : result + " Million";
        }


        private string ConvertThousandToString()
        {
            var result = new Thousands(ThousandLevelNumber).ConvertToWord();
            return result == null ? null : result;
        }




    }
}
