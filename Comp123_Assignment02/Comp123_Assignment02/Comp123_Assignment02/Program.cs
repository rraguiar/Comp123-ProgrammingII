using System;

namespace Comp123_Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Phase 1: create a new tweet file and input some test data.
            //InputTweetToFile();

            //Phase 2: test read the input from file and show it on screen
            //GetDataFromFileAndShow();

            //Phase 3: add new tweets to file and save them to file
            //AddNewTweetToFile();

            //Phase 4: You could use get data from file and show to check for the content of file
            //tag: assignment, test
            GetDataFromFileAndShow();

            Console.ReadLine();
        }

        static void InputTweetToFile() {            
            TweetManager.Initialize();
            TweetManager.WriteTweetToFile();
        }

        static void GetDataFromFileAndShow() {
            new TweetManager();
            TweetManager.ShowAll();
        }

        static void GetDataFromFileAndShow(string tag) {
            new TweetManager();
            TweetManager.ShowAll(tag);
        }

        static void AddNewTweetToFile() {            
            for (int i = 0; i < 5; i++)
            {
                Tweet t = new Tweet("Henry", "My manager", $"doing assignment + {i + 1}", "assignment");
                Console.WriteLine(t);
                TweetManager.AddTweet(t);
            }
            TweetManager.WriteTweetToFile();
        }
    }
}
