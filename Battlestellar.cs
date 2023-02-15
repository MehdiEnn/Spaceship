using SpaceshipProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlestellar
{
    class Battlestellar
    {
        public void Main(string[] args)
        {
            Guid guidB = Guid.NewGuid();
            Spaceship battlestellar = new Spaceship("Battlestellar", guidB.ToString(), 50, 25, 100, Spaceship.Status.Dock.ToString());
            battlestellar.vaisseaux.Add(battlestellar);
        }

    }
}
