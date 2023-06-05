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
            ShowSongsFromCollection(_songs70s);
            ShowSongsFromCollection(_songs80s);
            ShowSongsFromCollection(_songs90s);
        }

        private void ShowSongsFromCollection(SongCollection collection)
        {
            Iterator iterator = collection.CreateIterator();

            while (iterator.HasNext())
            {
                object song = iterator.Next();
                Console.WriteLine(song);
            }
        }
    }
}
