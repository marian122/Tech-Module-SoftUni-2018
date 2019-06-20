using System;
using System.Collections.Generic;
using System.Linq;

namespace MeTubeStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Dictionary<string, int[]>();

            string input = Console.ReadLine();

            while (input != "stats time")
            {
                if (input.Contains("-"))
                {
                    string[] tokens = input.Split('-');
                    string names = tokens[0];
                    int views = int.Parse(tokens[1]);

                    if (!video.ContainsKey(names))
                    {
                        video[names] = new int[2];
                    }
                    video[names][0] += views;
                }
                else if (input.Contains(':'))
                {
                    string[] tokens = input.Split(':');
                    string like = tokens[0];
                    string name = tokens[1];

                    if (video.ContainsKey(name))
                    {
                        if (like == "like")
                        {
                            video[name][1]++;
                        }
                        else if (like == "dislike")
                        {
                            video[name][1]--; 
                        }
                    }
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            if (input == "by views")
            {
                foreach (var videos in video.OrderByDescending(v => v.Value[0]))
                {
                    string name = videos.Key;
                    int views = videos.Value[0];
                    int likes = videos.Value[1];
                    Console.WriteLine($"{name} - {views} views - {likes} likes");
                }
            }
            else if (input == "by likes")
            {
                foreach (var videos in video.OrderByDescending(v => v.Value[1]))
                {
                    string name = videos.Key;
                    int views = videos.Value[0];
                    int likes = videos.Value[1];
                    Console.WriteLine($"{name} - {views} views - {likes} likes");
                }
            }
        }
    }
}
