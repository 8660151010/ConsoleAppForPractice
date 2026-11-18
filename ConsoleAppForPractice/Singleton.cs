namespace ConsoleAppForPractice
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new(() => new Singleton());
        private Singleton()
        {
            
        }

        public static Singleton singleton { get { return lazy.Value; } }
    }
}
