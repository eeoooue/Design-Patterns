using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Info
{
    internal class SongsOfThe70s
    {
        public List<SongInfo> _bestSongs;

        public SongsOfThe70s()
        {
            _bestSongs = new List<SongInfo>();

            addSong("Imagine", "John Lennon", 1971);
            addSong("American Pie", "Don McLean", 1971);
            addSong("I Will Survive", "Gloria Gaynor", 1979);
        }

        public void addSong(string title, string artist, int releaseYear)
        {
            SongInfo song = new SongInfo(title, artist, releaseYear);
            _bestSongs.Add(song);
        }

        public List<SongInfo> getBestSongs()
        {
            return _bestSongs;
        }
    }
}
