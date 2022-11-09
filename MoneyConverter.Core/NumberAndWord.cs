namespace MoneyConverter.Core
{
    public class NumberAndWord
    {
        public NumberAndWord()
        {

        }

        public NumberAndWord(int number, string word)
        {
            Number = number;
            Word = word;
        }
        public int Number { get; set; }
        public string Word { get; set; }
    }
}
