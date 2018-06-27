using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPlex.Models
{
    class Post
    {
        private DateTime dateTime;
        private String content;
        private String name;
        private String img_url;
        private int position;

        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public string Content { get => content; set => content = value; }
        public string Name { get => name; set => name = value; }
        public string Img_url { get => img_url; set => img_url = value; }
        public int Position { get => position; set => position = value; }
    }
}
