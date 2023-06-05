using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Info
{
    internal class DiskJockey
    {
        SongsOfThe70s _songs70s;
        SongsOfThe80s _songs80s;
        SongsOfThe90s _songs90s;

        public DiskJockey(SongsOfThe70s songs70s, SongsOfThe80s songs80s, SongsOfThe90s songs90s)
        {
            _songs70s = songs70s;
            _songs80s = songs80s;
            _songs90s = songs90s;
        }

        public void ShowTheSongs()
        {
            ShowBest70s();
            ShowBest80s();
            ShowBest90s();
        }

        private void ShowBest70s()
        {
            List<SongInfo> songs = _songs70s.getBestSongs();

            foreach (SongInfo song in songs)
            {
                Console.WriteLine(song);
            }
        }

        private void ShowBest80s()
        {
            SongInfo[] songs = _songs80s.getBestSongs();

            foreach (SongInfo song in songs)
            {
                Console.WriteLine(song);
            }
        }

        private void ShowBest90s()
        {
            Dictionary<int, SongInfo> songs = _songs90s.getBestSongs();

            foreach (SongInfo song in songs.Values)
            {
                Console.WriteLine(song);
            }
        }
    }
}
