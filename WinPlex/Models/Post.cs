using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPlex.Models
{
    public class Post
    {
        private String name;
        private String img_url;
        private String lattitude;
        private String longitude;
        private String content;
        private DateTime date;

        public Post(string name, string img_url, string lattitude, string longitude, string content, DateTime date)
        {
            this.name = name;
            this.img_url = img_url;
            this.lattitude = lattitude;
            this.longitude = longitude;
            this.content = content;
            this.date = date;
        }

        public Post()
        {

        }

        public string Name { get => name; set => name = value; }
        public string Img_url { get => img_url; set => img_url = value; }
        public string Lattitude { get => lattitude; set => lattitude = value; }
        public string Longitude { get => longitude; set => longitude = value; }
        public string Content { get => content; set => content = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
