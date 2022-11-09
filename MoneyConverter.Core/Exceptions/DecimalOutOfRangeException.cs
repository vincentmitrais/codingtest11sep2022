namespace MoneyConverter.Core.Exceptions
{
    public class DecimalOutOfRangeException : ArgumentOutOfRangeException
    {
        public DecimalOutOfRangeException(string message) : base(message) { }
    }
}
