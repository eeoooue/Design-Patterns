using Home_Theatre.Appliances;

namespace Home_Theatre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PopcornPopper popper = new PopcornPopper();
            popper.On();
            popper.Pop();

            TheaterLights lights = new TheaterLights();
            lights.Dim();

            Screen screen = new Screen();
            screen.Down();

            Projector projector = new Projector();
            projector.On();
            projector.SetInput();
            projector.SetWidescreenMode();

            Amplifier amp = new Amplifier();
            amp.On();
            amp.SetDVD();
            amp.SetSurroundSound();
            amp.SetVolume(5);

            DvdPlayer dvd = new DvdPlayer();
            dvd.On();
            dvd.Play("Ferris Bueller's Day Off");
        }
    }
}