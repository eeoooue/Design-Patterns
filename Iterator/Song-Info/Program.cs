namespace Song_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SongsOfThe70s songs70s = new SongsOfThe70s();
            SongsOfThe80s songs80s = new SongsOfThe80s();
            SongsOfThe90s songs90s = new SongsOfThe90s();

            DiskJockey dj = new DiskJockey(songs70s, songs80s, songs90s);

            dj.ShowTheSongs();
        }
    }
}