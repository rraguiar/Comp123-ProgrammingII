using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Tweet
{
    class Tweet
    {
        public string From;
        public string To;
        public string Body;
        public string Tag;
        public string Id;
    }
    public Tweet (string from, string to, string body, string tag)
    {
        From = from;
        To = to;
        Body = body;
        Tag = tag;
    }
}