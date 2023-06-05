using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Info
{
    internal class SongsOfThe90s : SongCollection
    {
        public Dictionary<int, SongInfo> _bestSongs;
        int _hashKey = 0;

        public SongsOfThe90s()
        {
            _bestSongs = new Dictionary<int, SongInfo>();

            addSong("Losing My Religion", "REM", 1991);
            addSong("Creep", "Radiohead", 1993);
            addSong("Walk on the Ocean", "Toad The Wet Sprocket", 1991);
        }

        public void addSong(string title, string artist, int releaseYear)
        {
            SongInfo song = new SongInfo(title, artist, releaseYear);
            _bestSongs[_hashKey++] = song;
        }

        public Iterator CreateIterator()
        {
            return new SongIterator(_bestSongs);
        }
    }
}
