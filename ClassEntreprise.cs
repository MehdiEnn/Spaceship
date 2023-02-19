using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Spaceships
{
    class Entreprise : Spaceship
    {
        protected int[] torpilles;
        int x = 40;
        public Entreprise()
        {
            this.Type = "Entreprise";
            this.Identifier = Guid.NewGuid().ToString();
            this.Energy = 50;
            this.attack = 50;
            this.Toughness = 50;
            this.status = Status.Docks.ToString();
            int[] torpilles = new int[x];
        }

        public override void Attack()
        {
            try
            {
                Energy -= 5;
                x -= 1;
                Console.WriteLine("{0} {1} shoots !", Type, Identifier);
                //Console.WriteLine("{0}'s new energy is : {1}", Type, Energy);
                //Console.WriteLine("number of rockets is : {0}", x);

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
