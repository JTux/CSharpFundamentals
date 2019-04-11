using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Repository_Pattern
{
    public enum GenreType
    {
        Horror = 1,
        Comedy,
        Drama,
        SciFi,
        Cartoon,
        Kids,
        Bromance,
        RomCom,
        Western,
        Thriller
    }

    public class StreamingContent
    {
        public string Title { get; set; }
        public int StarRating { get; set; }
        public GenreType Genre { get; set; }
        public bool IsMature { get; set; }
        public string Rating { get; set; }
        public double RunTime { get; set; }

        public StreamingContent() { }
        public StreamingContent(string title, int starRating, GenreType genre, bool isMature, string rating, double runTime)
        {
            Title = title;
            StarRating = starRating;
            Genre = genre;
            IsMature = isMature;
            Rating = rating;
            RunTime = runTime;
        }
    }
}
