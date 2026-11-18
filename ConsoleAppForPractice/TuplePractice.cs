namespace ConsoleAppForPractice
{
    public class TuplePractice
    {
        public Tuple<int, string, string, long, string> GetData()
        {
            var tuple = Tuple.Create(101, "Prashant", "prashant88684@gmail.com", 8660151010, "Dev");
            return tuple;
        }
    }
}
