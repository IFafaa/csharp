namespace OnlineCourses {
    internal class Program {
        static HashSet<int> ids = new HashSet<int>();

        static void Main(string[] args) {
            char[] courses = { 'A', 'B', 'C' };
            for (int i = 0; i < courses.Length; i++) {
                AdjustStudents(courses[i]);
            }

            Console.WriteLine("Total students: " + ids.Count);
        }

        static void AdjustStudents(char course) {
            Console.Write($"How many students for course {course}?");
            int qnt = int.Parse( Console.ReadLine() );  
            for( int i = 0; i < qnt; i++ ) {
                ids.Add(int.Parse(Console.ReadLine()));
            }
        }
    }
}