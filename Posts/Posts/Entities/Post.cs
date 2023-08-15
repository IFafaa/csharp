using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Entities {
    internal class Post {
        public DateTime Moment { get; private set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public int Likes { get; set; }

        public List<Comment> comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes) {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void addComment(Comment comment) {
            comments.Add(comment);
        }

        public void removeComment(Comment comment) {
            comments.Remove(comment);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append($"{Likes} Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment comment in comments) {
                sb.AppendLine(comment.Text);
            };
            return sb.ToString();



        }
    }
}
