using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Info
{
    internal class SongInfo
    {
        public string Title { get; private set; }
        public string Artist { get; private set; }
        public int Year { get; private set; }

        public SongInfo(string title, string artist, int releaseYear)
        {
            Title = title;
            Artist = artist;
            Year = releaseYear;
        }
    }
}
