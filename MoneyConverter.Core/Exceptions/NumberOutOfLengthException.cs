namespace MoneyConverter.Core.Exceptions
{
    public class NumberOutOfLengthException : ArgumentOutOfRangeException
    {
        public NumberOutOfLengthException(string message) : base(message)
        {

        }
    }
}
