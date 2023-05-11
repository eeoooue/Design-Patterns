using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    /// <summary>
    /// Patron of the restaurant (duh!)
    /// </summary>
    class Patron
    {
        private string _name;
        public string Name { get { return _name; } }

        public Patron(string name)
        {
            _name = name;
        }
    }
}
