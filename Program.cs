using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceGuillaume1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Spaceship spaceship = new Spaceship();
            spaceship.Launch();
            spaceship.Attack();
            spaceship.Move();
            spaceship.Destruction();

            Battlestellar battlestellar = new Battlestellar();
            battlestellar.Launch();
            battlestellar.Attack();
            battlestellar.Move();
            battlestellar.Destruction();

            Entreprise entreprise = new Entreprise();
            entreprise.Launch();
            entreprise.Attack();
            entreprise.Attack();
            entreprise.Attack();
            entreprise.Move();
            entreprise.Destruction();

        }
    }

    interface ISpaceship
    {
        void Attack();
        void Move();
    }
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
