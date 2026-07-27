namespace HashSet_e_SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("a");
            set.Add("b");
            set.Add("c");

            Console.WriteLine(set.Contains("a"));

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 8, 4, 5, 16 };
            SortedSet<int> b = new SortedSet<int>() { 6, 7, 8, 9, 10, 16 };


            //Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            PrintCollection(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            d.ExceptWith(b);
            PrintCollection(e);

            static void PrintCollection<T>(IEnumerable<T> collection)
            {
                foreach (T item in collection)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();

            }
        }
    }
}
