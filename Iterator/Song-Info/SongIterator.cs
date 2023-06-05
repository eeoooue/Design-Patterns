using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Info
{
    internal class SongIterator : Iterator
    {
        List<SongInfo> _songs = new List<SongInfo>();
        int position = 0;

        public SongIterator(List<SongInfo> songCollection)
        {
            foreach (SongInfo song in songCollection)
            {
                _songs.Add(song);
            }
        }

        public SongIterator(SongInfo[] songCollection)
        {
            foreach (SongInfo song in songCollection)
            {
                _songs.Add(song);
            }
        }

        public SongIterator(Dictionary<int, SongInfo> songCollection)
        {
            foreach (SongInfo song in songCollection.Values)
            {
                _songs.Add(song);
            }
        }

        public bool HasNext()
        {
            return (position < _songs.Count && _songs[position] != null);
        }

        public object Next()
        {
            return _songs[position++];
        }
    }
}
