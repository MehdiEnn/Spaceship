using SpaceshipProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceshipOnMission
{
    class SpaceshipOnMission
    {
        public static void Main(string[] args)
        {
            Guid guid = Guid.NewGuid();
            Spaceship spaceship = new Spaceship("Spaceship", guid.ToString(), 50, 25, 15, Spaceship.Status.Dock.ToString());
            spaceship.Launch();
            spaceship.vaisseaux.Add(spaceship);
            
        }
    }
}

