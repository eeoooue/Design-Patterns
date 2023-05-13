using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Theatre
{
    internal class DvdPlayer : Appliance
    {
        public void Play(string movie)
        {
            Console.WriteLine($"Now playing {movie}");
        }
    }
}
