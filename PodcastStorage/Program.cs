using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastStorage
{
    class Program
    {
        private static List<Podcast> _podcastList = new List<Podcast>();

        static void Main(string[] args)
        {
            fillPodcastList();
            foreach (var podcast in _podcastList)
            {
                Console.WriteLine(podcast.Name + "; " + podcast.Country + "; " + podcast.Category);
            }
            Console.ReadKey();
        }

        private static void fillPodcastList()
        {
            _podcastList.Add(new Podcast
            {
                Name = "Luke's English Podcast",
                Country = "England",
                Category = PodcastCategory.Education,
                AverageLength = 60
            });
            _podcastList.Add(new Podcast
            {
                Name = "RadioLab",
                Country = "USA",
                Category = PodcastCategory.Science,
                AverageLength = 60
            });
        }
    }
}
