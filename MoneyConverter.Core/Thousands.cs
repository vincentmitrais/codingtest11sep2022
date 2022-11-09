using MoneyConverter.Core.Extentions;
using MoneyConverter.Core.Interfaces;

namespace MoneyConverter.Core
{
    public class Thousands : INumberConverter
    {

        public int Number { get; set; }
        private string MaxDigitNumber { get; set; }
        private int ThousandLevelNumber => Convert.ToInt32(MaxDigitNumber.Substring(0, 3));
        private int HundredLevelNumber => Convert.ToInt32(MaxDigitNumber.Substring(3, 3));



        public Thousands(int number)
        {
            if (number < 0 && number > 999_999)
                throw new System.ArgumentOutOfRangeException("Input number is out of range. The number should >= 1000 and number <= 999 999");

            Number = number;
            MaxDigitNumber = $"000000{Number}";
            MaxDigitNumber = MaxDigitNumber.Substring(MaxDigitNumber.Count() - 6, 6);
        }


        public string ConvertToWord()
        {
            var thousand = ConvertThousandString();
            var hundred = ConvertHundredString();
            var result = $"{thousand}{(hundred == null ? null : (thousand == null ? "" : " ") + hundred)}";
            return result == null || result == string.Empty ? null : result.Replace("  ", " ");
        }



        private string ConvertThousandString()
        {
            if (ThousandLevelNumber == 0)
                return null;

            var result = ThousandLevelNumber.GenerateConverter3Digit()?.ConvertToWord() + " ";
            return result == null || result == string.Empty ? null : result + " Thousand";
        }


        private string ConvertHundredString()
        {
            var result = new Hundreds(HundredLevelNumber).ConvertToWord();
            return result == null || result == string.Empty ? null : result;
        }



    }
}
