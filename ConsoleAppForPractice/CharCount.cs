namespace ConsoleAppForPractice
{
    public class CharCount
    {        

        public void CountCharachters()
        {
            Console.WriteLine("Enter a string to count characters:");
            string inputString = Console.ReadLine();

            Dictionary<char, int> charCountDictionary = new();

            foreach (char c in inputString)
            {
                if (charCountDictionary.ContainsKey(c))
                    charCountDictionary[c]++;
                else
                    charCountDictionary[c] = 1;
            }

            //For Displaying the character count
            foreach (var kvp in charCountDictionary)
            {
                Console.WriteLine($"Character: '{kvp.Key}' Count: {kvp.Value}");
            }
        }

        public void CountCharachtersUsingLINQ()
        {
            Console.WriteLine("Enter a string to count characters:");
            string inputString = Console.ReadLine();

            var charCount = inputString.GroupBy(c => c).Select(g => new { Character = g.Key, Count = g.Count() });

            foreach (var item in charCount)
            {
                Console.WriteLine($"Character: '{item.Character}' Count: {item.Count}");
            }
        }

    }
}
