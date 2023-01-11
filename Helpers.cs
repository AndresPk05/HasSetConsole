namespace HasSetConsole
{
    public static class Helpers
    {
        public static IEnumerable<T> RemoveElementsDuplicated<T>(IEnumerable<T> List)
        {
            HashSet<T> values = new HashSet<T>(List);
            return values;
        }

        public static IEnumerable<T> RemoveElementsDuplicated<T>(IEnumerable<T> List, IEqualityComparer<T> EqualityComparer)
        {
            HashSet<T> values = new HashSet<T>(List, EqualityComparer);
            return values;
        }
    }
}
