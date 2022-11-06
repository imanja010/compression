using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compression
{
    internal class Symbol
    {
        public Symbol(char value, int numberOfTimes, int totalChars)
        {
            Value = value;
            NumberOfTimes = numberOfTimes;
            Test = (double)numberOfTimes / (double)totalChars;
        }
        public int NumberOfTimes { get; set; }
        public char Value { get; set; }
        public double Test { get; set; }
        public List<bool> TotalValue { get; set; } = new List<bool>();
    }
}
