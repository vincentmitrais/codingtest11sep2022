using MoneyConverter.Core.Extentions;
using MoneyConverter.Core.Interfaces;

namespace MoneyConverter.Core
{
    public class Trillions : INumberConverter
    {

        public Int64 Number { get; set; }
        private string MaxDigitNumber { get; set; }
        private int TrillionGroupNumber => Convert.ToInt32(MaxDigitNumber.Substring(0, 3));
        private Int64 BillionLevelNumber => Convert.ToInt64(MaxDigitNumber.Substring(3, 12));



        public Trillions(Int64 number)
        {
            if (number < 0 && number > 999_999_999_999_999)
                throw new System.ArgumentOutOfRangeException("Input number is out of range. The number should >= 1000000 and number <= 999999999999");

            Number = number;
            MaxDigitNumber = $"00000000000000{Number}";
            MaxDigitNumber = MaxDigitNumber.Substring(MaxDigitNumber.Count() - 15, 15);
        }


        public string ConvertToWord()
        {
            var trillion = ConvertTrillionLevel();
            var billion = ConvertBillionLevel();
            return $"{trillion}{(billion == null ? null : (trillion == null ? "" : " ") + billion)}";
        }


        private string ConvertTrillionLevel()
        {
            if (TrillionGroupNumber == 0)
                return null;
            var result = TrillionGroupNumber.GenerateConverter3Digit()?.ConvertToWord();
            return result == null || result == string.Empty ? null : result + " Trillion";
        }


        private string ConvertBillionLevel()
        {
            var result = new Billions(BillionLevelNumber).ConvertToWord();
            return result == null || result == string.Empty ? null : result;
        }


    }
}
