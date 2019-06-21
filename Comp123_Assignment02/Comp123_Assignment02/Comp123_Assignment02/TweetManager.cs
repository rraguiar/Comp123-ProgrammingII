using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Comp123_Assignment02
{
    class TweetManager
    {
        //Reserve List and Filename in memory
        static List<Tweet> Tweets;
        static string FileName;

        static TweetManager()
        {
            //Set Filename
            FileName = "test.txt";
            //Intialize List
            Tweets = new List<Tweet>();

            //Run the following code if filename can be found
            if (File.Exists(FileName))
            {

                TextReader reader = new StreamReader(FileName);
                string line;
                while ((line = reader.ReadLine()) != null
                    && line.Length != 0)
                {
                    Tweet newT = Tweet.Parse(line);
                    Tweets.Add(newT);
                }
                reader.Close();
            }
        }

        //Initialize a list for testing
        public static void Initialize() {
            int testCount = 5;
            Tweets = new List<Tweet>();
            //Add 5 sample tweets to the list
            for (int i = 0; i < testCount; i++)
            {
                Tweet t = new Tweet("Henry", "My Friends", $"This is the {i} test message to my friend", "test");
                Tweets.Add(t);
            }
        }
        public static void WriteTweetToFile() {
            //Delete file for clean slate start if previous file exists
            if (File.Exists(FileName))
            {
                File.Delete(FileName);
            }            
            TextWriter writer = new StreamWriter(FileName);
            //Print tweet to file line by line
            foreach (Tweet item in Tweets)
            {
                writer.WriteLine(item.From +"\t" + item.To + "\t" + item.Body + "\t" + item.Tag + "\t" + item.Id);
            }
            writer.Close();
        }

        //Dislpay every tweet in tweets
        public static void ShowAll() {
            foreach (Tweet tweet in Tweets)
            {
                Console.WriteLine(tweet);
            }
        }

        //Display tweet if it has the tag
        public static void ShowAll(string tag) {
            foreach (Tweet tweet in Tweets)
            {
                if (tweet.Tag == tag)
                {
                    Console.WriteLine(tweet);
                }                
            }
        }
        
        //Add tweet to list
        public static void AddTweet(Tweet tweet) {
            Tweets.Add(tweet);
        }
    }
}
