using System;

namespace HashSetSortedSet {
    internal class Program {
        static void Main(string[] args) {
            HashSet<string> set = new HashSet<string>();

            set.Add("tv");
            set.Add("notebook");
            set.Add("tablet");
            Console.WriteLine(set.Contains("tg"));
            foreach (var str in set) {
                Console.WriteLine(str);
            }

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8,9 ,10 };

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            //intersection

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);


            SortedSet<int> e = new SortedSet<int> (a);
            e.ExceptWith(b);

            PrintCollection(c);
            PrintCollection(d);
            PrintCollection(e);


        }

        static void PrintCollection<T>(IEnumerable<T> collection) {
            foreach(T obj in collection) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}