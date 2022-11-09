using MoneyConverter.Core.Extentions;
using MoneyConverter.Core.Interfaces;

namespace MoneyConverter.Core
{
    public class Billions : INumberConverter
    {

        public Int64 Number { get; set; }
        private string MaxDigitNumber { get; set; }
        private int BillionLevelNumber => Convert.ToInt32(MaxDigitNumber.Substring(0, 3));
        private int MillionLevelNumber => Convert.ToInt32(MaxDigitNumber.Substring(3, 9));



        public Billions(Int64 number)
        {
            if (number < 0 && number > 999_999_999_999)
                throw new System.ArgumentOutOfRangeException("Input number is out of range. The number should >= 1000000 and number <= 999999999999");

            Number = number;
            MaxDigitNumber = $"000000000000{Number}";
            MaxDigitNumber = MaxDigitNumber.Substring(MaxDigitNumber.Count() - 12, 12);
        }


        public string ConvertToWord()
        {
            var billion = ConvertBillionToString();
            var million = ConvertMillionToString();
            return $"{billion}{(million == null ? null : (billion == null ? "" : " ") + million)}";
        }


        private string ConvertBillionToString()
        {
            if (BillionLevelNumber == 0)
                return null;

            var result = BillionLevelNumber.GenerateConverter3Digit()?.ConvertToWord();
            return result == null ? null : result + " Billion";
        }


        private string ConvertMillionToString()
        {
            var result = new Millions(MillionLevelNumber).ConvertToWord();
            return result == null || result == string.Empty ? null : result;
        }


    }
}
