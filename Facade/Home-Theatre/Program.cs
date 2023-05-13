
namespace Home_Theatre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade();
            homeTheaterFacade.WatchMovie("Ferris Bueller's Day Off");
        }
    }
}