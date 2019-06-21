using System;
using System.Collections.Generic;
using System.Text;

namespace Comp123_Assignment02
{
    class Tweet
    {
        static int CURRENT_ID = 0;
        //Property Fields
        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Tag { get; }
        public int Id { get; }

        //Tweet Constructor
        public Tweet(string from, string to, string body, string tag)
        {
            From    = from;
            To      = to;
            Body    = body;
            Tag     = tag;

            Id      = Tweet.CURRENT_ID++;

        }
        //Tweet Constructor Overload with ID
        public Tweet(string from, string to, string body, string tag, int id)
        {
            From    = from;
            To      = to;
            Body    = body;
            Tag     = tag;
            Id      = id;   
        }


        //body is full conversation so we do not need to substring it
        public override string ToString()
        {
            return Body;
        }


        public static Tweet Parse(string stringToParse)
        {
            //Store string in array, delimiter is tab
            string[] values = stringToParse.Split('\t');
            //array element[0] 1 = From Whom
            //array element[1] 2 = To Whom
            //array element[2] 3 = Body of the Tweet
            //array element[3] 4 = HashTag???
            //array element[4] 5 = ID of the tweet
            Tweet result = new Tweet(values[0], values[1], values[2], values[3], Convert.ToInt32(values[4]));
            //Return Tweet
            return result;
        }
    }
}
