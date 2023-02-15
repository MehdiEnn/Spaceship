using SpaceshipProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entreprise
{
    class Entreprise
    {
        int[] torpille = new int[40];
        int torpillelength;
        string identifier;
        int energy;
        public void Main(string[] args)
        {
            Guid guidE = Guid.NewGuid();
            torpillelength = Convert.ToInt32(torpille.Length);
            Spaceship entreprise = new Spaceship("Entreprise", guidE.ToString(), 50, 50, 100, Spaceship.Status.Dock.ToString());
            entreprise.vaisseaux.Add(entreprise);
            entreprise.SetIdentifier(guidE.ToString());
            entreprise.SetEnergy(50);
            identifier = entreprise.GetIdentifier();
            energy= entreprise.GetEnergy();
        }

        public void attack()
        {
            Spaceship entreprise = new Spaceship("Entreprise", identifier, energy, 50, 100, Spaceship.Status.Dock.ToString());
            entreprise.toAttack();
            torpillelength = torpillelength - 1;
        }



    }
}
