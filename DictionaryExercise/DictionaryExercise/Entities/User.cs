namespace DictionaryExercise.Entities {
    internal class User {
        public string Name { get; set; }
        public int Value { get; set; }

        public User(string name, int value) {
            Name = name;
            Value = value;
        }

        public void AddValues(int values) {
            Value += values;
        }
    }
}
