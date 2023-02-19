using ExerciceGuillaume1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Spaceships
{
    class Spaceship : ISpaceship
    {
        protected string Type;
        protected string Identifier;
        protected int Energy;
        protected int attack;
        protected int Toughness;
        protected string status;

        public Spaceship()
        {
            this.Type = "Spaceship";
            this.Identifier = Guid.NewGuid().ToString();
            this.Energy = 50;
            this.attack = 25;
            this.Toughness = 15;
            this.status = Status.Docks.ToString();
        }

        public void Launch()
        {
            Console.WriteLine("{0} {1} is ready to fly.", Type, Identifier);
        }

        public virtual void Attack()
        {
            Energy -= 5;
            Console.WriteLine("{0} {1} shoots !", Type, Identifier);
            //Console.WriteLine("{0}'s new energy is : {1}", Type, Energy);
        }

        public void Move()
        {
            try
            {
                Energy -= 3;
                Console.WriteLine("{0} {1} has moved.", Type, Identifier);
                //Console.WriteLine("{0}'s new energy is : {1}", Type, Energy);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Destruction()
        {
            Console.WriteLine("{0} {1} destroyed!", Type, Identifier);
            status = Status.Destroyed.ToString();
            //Console.WriteLine("{0}'s new energy is {1}, status is {2}", Type, Energy, status);
        }

        public enum Status
        {
            Docks,
            Destroyed,
            Fly,
        }
    }
}
