using MoneyConverter.Core.Interfaces;

namespace MoneyConverter.Core.Extentions
{
    internal static class IntegerConverterExtention
    {
        public static INumberConverter GenerateConverter3Digit(this int value)
        {
            if (value.ToString().Length > 3 && value <= 0)
                throw new ArgumentOutOfRangeException("Value must be less then 1000 and greater then -1");

            return value == 0 ? null :
                value > 99 ? new Hundreds(value) :
                value > 9 ? new Dozens(value) :
                new Basics(value);
        }
    }
}
