using Home_Theatre.Appliances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Theatre
{
    internal class HomeTheaterFacade
    {
        private Amplifier _amp;
        private Tuner _tuner;
        private DvdPlayer _dvd;
        private CdPlayer _cd;
        private Projector _projector;
        private TheaterLights _lights;
        private Screen _screen;
        private PopcornPopper _popper;

        public HomeTheaterFacade()
        {
            _amp = new Amplifier();
            _tuner = new Tuner();
            _dvd = new DvdPlayer();
            _cd = new CdPlayer();
            _projector = new Projector();
            _screen = new Screen();
            _lights = new TheaterLights();
            _popper = new PopcornPopper();
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _popper.On();
            _popper.Pop();
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.SetWidescreenMode();
            _amp.On();
            _amp.SetDvd("dvd");
            _amp.SetSurroundSound();
            _amp.SetVolume(5);
            _dvd.On();
            _dvd.Play(movie);
            EndMovie();
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvd.Stop();
            _dvd.Eject();
            _dvd.Off();
        }
    }
}
