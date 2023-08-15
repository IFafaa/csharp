using LoginLogs.Entities;
using System;

namespace LoginLogs {
    internal class Program {
        static void Main(string[] args) {
            string path = @"C:\temp\login-log.txt";

            HashSet<User> users = new HashSet<User>();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while(!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(" ");
                        string username = line[0];
                        DateTime time = DateTime.Parse(line[1]);
                        User user = new User(username, time);
                        users.Add(user);
                    }
                    Console.WriteLine("Total users: " + users.Count);

                    Console.WriteLine("USERS:");
                    foreach (User user in users) {
                        Console.WriteLine(user.Username);
                    }
                }
            }catch(IOException e) {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}