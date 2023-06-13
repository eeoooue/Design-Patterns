namespace Video_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoConverter converter = new VideoConverter();
            GeneralFile convertedVideo = converter.Convert("mymovie", "ogg");

            Console.WriteLine($"Created converted video at {convertedVideo.Filename}");
        }
    }
}