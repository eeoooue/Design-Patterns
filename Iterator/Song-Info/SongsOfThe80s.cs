using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Info
{
    internal class SongsOfThe80s
    {
        public SongInfo[] _bestSongs;
        public int arrayPosition = 0;

        public SongsOfThe80s()
        {
            _bestSongs = new SongInfo[3];

            addSong("Roam", "B 52s", 1989);
            addSong("Cruel Summer", "Bananarama", 1984);
            addSong("Head Over Heels", "Tears For Fears", 1985);
        }

        public void addSong(string title, string artist, int releaseYear)
        {
            SongInfo song = new SongInfo(title, artist, releaseYear);
            _bestSongs[arrayPosition++] = song;
        }

        public SongInfo[] getBestSongs()
        {
            return _bestSongs;
        }
    }
}
