namespace Compression
{
    internal class Symbol
    {
        public Symbol(char value, int numberOfTimes, int totalChars)
        {
            Value = value;
            NumberOfOccurrences = numberOfTimes;
            Test = (double)numberOfTimes / (double)totalChars;
        }
        public int NumberOfOccurrences { get; set; }
        public char Value { get; set; }
        public double Test { get; set; }
        public List<bool> Result { get; set; } = new List<bool>();
    }
}
