using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLogs.Entities {
    internal class User {

        public string Username { get; set; }
        public List<DateTime> HistoryLogins{ get; set; } = new List<DateTime>();

        public User(string username, DateTime loginTime) { 
            Username = username;
            setTimeInHistoryLogin(loginTime);
        }

        public void setTimeInHistoryLogin(DateTime time) {
            HistoryLogins.Add(time);
        }

        public override string ToString() {
            return Username + " " + HistoryLogins.Last().ToString();
        }

        public override int GetHashCode() {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj) {
            if(obj == null || !(obj is User)) return false;
            return Username.Equals(((User)obj).Username);
        }
    }
}
