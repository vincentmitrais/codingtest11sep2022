using MoneyConverter.Core.Interfaces;

namespace MoneyConverter.Core
{
    public class Hundreds : INumberConverter
    {

        public int Number { get; set; }
        private string MaxDigitNumber { get; set; }
        private int HundredLevelNumber => Convert.ToInt32(MaxDigitNumber.Substring(0, 1));
        private int DozenLevelNumber => Convert.ToInt32(MaxDigitNumber.Substring(1, 2));

        public Hundreds(int number)
        {
            if (number < 0 && number > 999)
                throw new System.ArgumentOutOfRangeException("Input number is out of range. The number should >= 100 and number <= 999");

            Number = number;
            MaxDigitNumber = $"000{Number}";
            MaxDigitNumber = MaxDigitNumber.Substring(MaxDigitNumber.Count() - 3, 3);
        }

        public string ConvertToWord()
        {
            var hudred = GenerateHudredString();
            var dozansOrBasic = GenerateDozenAndBasicString();

            if (hudred != null && dozansOrBasic != null && dozansOrBasic != string.Empty)
                return $"{hudred} and {dozansOrBasic}";

            if (hudred != null && (dozansOrBasic == null || dozansOrBasic == string.Empty))
                return hudred;

            return dozansOrBasic;

        }


        private string GenerateHudredString()
        {
            if (HundredLevelNumber == 0)
                return null;

            var basic = new Basics(HundredLevelNumber);
            return $"{basic.ConvertToWord()} Hundred";
        }


        private string GenerateDozenAndBasicString()
        {
            if (DozenLevelNumber == 0)
                return null;

            INumberConverter dozensOrBasics = DozenLevelNumber > 9 ? new Dozens(DozenLevelNumber) : new Basics(DozenLevelNumber);
            return dozensOrBasics.ConvertToWord();
        }


    }
}
