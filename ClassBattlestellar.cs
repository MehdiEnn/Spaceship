using ExerciceGuillaume1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Spaceships
{
    class Battlestellar : Spaceship
    {
        public Battlestellar()
        {
            this.Type = "Battlestellar";
            this.Identifier = Guid.NewGuid().ToString();
            this.Energy = 50;
            this.attack = 25;
            this.Toughness = 100;
            this.status = Status.Docks.ToString();
        }
    }
}
