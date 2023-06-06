using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Ships
{
    abstract class EnemyShip
    {
        public string Name { get; private set; }

        public double Speed { get; private set; }

        public double Damage { get; private set; }

        public EnemyShip(string name, double speed, double damage)
        {
            Name = name;
            Speed = speed;
            Damage = damage;
        }
    }
}
