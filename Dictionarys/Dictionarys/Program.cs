namespace Dictionarys {
    internal class Program {
        static void Main(string[] args) {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "teste@teste.com";
            cookies["phone"] = "92849343403";
            cookies["phone"] = "23213213255";

            if(cookies.ContainsKey("email") ) {
                cookies.Remove("email");
            }
            else {
                Console.WriteLine(cookies["email"]);
            }

            Console.WriteLine("Size: " + cookies.Count);
            foreach(KeyValuePair<string, string> kvp in cookies) {
                Console.WriteLine(kvp.Key + " - " + kvp.Value) ;
            }

        }
    }
}