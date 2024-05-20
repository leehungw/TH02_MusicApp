using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TH02_MusicApp.Model
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string songId { get; set; }
        public string author { get; set; }
        public string content { get; set; }
        public int star { get; set; }

        public Comment()
        {
            Id = Guid.NewGuid();
            this.songId = "";
            this.author = "";
            this.content = "";
            this.star = 0;
        }

        public Comment(string songId, string content, string author, int star)
        {
            this.Id = Guid.NewGuid();
            this.songId = songId;
            this.author = author;
            this.content = content;
            this.star = star;
        }
    }
}
