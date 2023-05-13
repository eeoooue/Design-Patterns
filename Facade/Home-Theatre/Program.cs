using Home_Theatre.Appliances;

namespace Home_Theatre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PopcornPopper popper = new PopcornPopper();
            popper.On();
            popper.Pop();


            Lights lights = new Lights();
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

            DVD dvd = new DVD();
            dvd.On();
            
            
        }
    }
}