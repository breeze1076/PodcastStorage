using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastStorage
{
    internal class Podcast
    {
        internal string Name { get; set; }
        internal string Country { get; set; }
        internal PodcastCategory Category { get; set; }
        internal int AverageLength { get; set; }
        internal string Language { get; set; }
    }

    internal enum PodcastCategory
    {
        Comedy,
        Education,
        News,
        Sociology,
        Science,
        Psychology,
        Music,
        History
    }
}
