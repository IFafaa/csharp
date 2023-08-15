using DictionaryExercise.Entities;

namespace DictionaryExercise {
    internal class Program {
        static void Main(string[] args) {
            string path = @"C:/temp/names_data.txt";
            Dictionary<string, int> names_data = new Dictionary<string, int>();

            try {

                using(StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        int value = int.Parse(line[1]);

                        if (names_data.ContainsKey(name)) {
                            int totalValue = names_data[name] += value;
                            names_data[name] = totalValue;
                        }
                        else {
                            names_data.Add(name, value);
                        }
                    }

                    foreach (KeyValuePair<string, int> item in names_data) {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                }

                


            }catch (IOException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}