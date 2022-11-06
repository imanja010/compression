namespace Compression
{
    internal class Shannon
    {
        internal void Start(string input)
        {
            var result = new List<Symbol>();
            var allChars = input.ToCharArray();
            int numberOfChars = input.Length;
            var groupedChars = allChars.GroupBy(x => x);
            foreach (var singleCharGroup in groupedChars)
            {
                result.Add(new Symbol(singleCharGroup.Key, singleCharGroup.Count(), numberOfChars));
            }
            var sortedList = result.OrderByDescending(x=>x.NumberOfOccurrences);
            var linkedList = new LinkedList<Symbol>(sortedList);
            Traverse(linkedList);
            Print(sortedList);
        }

        private void Print(IEnumerable<Symbol> result)
        {
            foreach (var res in result)
            {
                Console.WriteLine(res.Value + " " + res.NumberOfOccurrences + " " + PrintValues(res.Result));
            }
        }

        private string PrintValues(IEnumerable<bool> values)
        {
            string result = string.Empty;
            foreach(var val in values)
            {
                result += val ? 1 : 0;
            }
            return result;
        }

        private void Traverse(LinkedList<Symbol> symbols)
        {
            if (symbols.Count <= 1)
            {
                return;
            }

            var higherList = new LinkedList<Symbol>();
            var total = symbols.Select(x => x.NumberOfOccurrences).Sum();
            int current = 0;
            do
            {
                var first = symbols.First();
                symbols.RemoveFirst();
                current += first.NumberOfOccurrences;
                first.Result.Add(true);
                higherList.AddLast(first);
            }
            while (current < total / 2);
            
            foreach(var symbol in symbols)
            {
                symbol.Result.Add(false);
            }

            Traverse(higherList);
            Traverse(symbols);
        }
    }
}
