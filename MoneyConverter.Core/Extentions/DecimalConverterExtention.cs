using MoneyConverter.Core.Exceptions;
using MoneyConverter.Core.Interfaces;
using System.Globalization;

namespace MoneyConverter.Core.Extentions
{
    public static class DecimalConverterExtention
    {
        public static string ConvertToWord(this decimal value)
        {
            var splits = value.ToString().Split(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator);

            if (splits.Count() == 2 && splits[1].Length > 2)
                throw new DecimalOutOfRangeException("Only 2 digits after comma is allowed");

            var mainString = splits[0];
            if (mainString.Length > 15)
                throw new NumberOutOfLengthException("The input number is too large");


            var dollarString = mainString.Length == 1 && (Convert.ToInt16(mainString) == 1) ? "Dollar" : "Dollars";
            var mainResultString = mainString.GenerateConverter()?.ConvertToWord();

            return mainResultString == null ? null :
                $"{mainResultString} {dollarString}{value.GenerateCent()}";

        }


        private static string GenerateCent(this decimal value)
        {
            var splits = value.ToString().Split(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator);

            if (splits.Count() == 2 && splits[1].Length > 2)
                throw new DecimalOutOfRangeException("Only 2 digits after comma is allowed");

            if (splits.Count() == 1)
                return null;

            var cent = splits.Count() == 2 ? Convert.ToInt16(splits[1]) : 0;
            var centAmountString = cent.GenerateConverter3Digit()?.ConvertToWord();
            var centString = (splits.Length == 2 && Convert.ToInt16(splits[1]) == 1) ? "Cent" : "Cents";

            return centAmountString == null ? null :
                $" and {centAmountString} {centString}";
        }



        private static INumberConverter GenerateConverter(this string value) => new Trillions(Convert.ToInt64(value));

        //=> value.Length >= 13 ? new Trillions(Convert.ToInt64(value)) :
        //    value.Length >= 10 ? new Billions(Convert.ToInt64(value)) :
        //    value.Length >= 7 ? new Millions(Convert.ToInt32(value)) :
        //    value.Length >= 4 ? new Thousands(Convert.ToInt32(value)) :
        //    (Convert.ToInt32(value)).GenerateConverter3Digit();

    }
}
