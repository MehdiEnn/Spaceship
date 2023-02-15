using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpaceshipProperties
{
    public class Spaceship : IAttack, IMove
    {
        protected string Type;
        protected string Identifier;
        protected int Energy;
        protected int Attack;
        protected int Toughness;
        protected string status;

        public Spaceship(string Type, string Identifier, int Energy, int Attack, int Toughness, string Status)
        {
            this.Type = Type;
            this.Identifier = Identifier;
            this.Energy = Energy;
            this.Attack = Attack;
            this.Toughness = Toughness;
            this.status = Status;
        }

        public List<Spaceship> vaisseaux= new List<Spaceship>();
        public void SetIdentifier(string guid)
        {
            guid = Guid.NewGuid().ToString();
            this.Identifier = guid;
        }
        public string GetIdentifier()
        {
            return this.Identifier;
        }

        public void SetEnergy(int _energy)
        {
            this.Energy = _energy;
        }
        public int GetEnergy()
        {
            return this.Energy;
        }

        public void SetType(string type)
        {
            this.Type = type;
        }
        public string GetType()
        {
            return this.Type;
        }

        public void Launch()
        {
            Console.WriteLine("{0} {1} is ready to fly.", Type, Identifier);
        }

        public void toAttack()
        {
            try
            {
                Energy -= 5;
                Console.WriteLine("{0} {1} shoots !", Type, Identifier);
                Console.WriteLine("{0}'s new energy is : {1}", Type, Energy);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void Move()
        {
            try
            {
                Energy -= 3;
                Console.WriteLine("{0} {1} has moved.", Type, Identifier);
                Console.WriteLine("{0}'s new energy is : {1}", Type, Energy);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Destruction()
        {
            if (Energy == 0 || Energy < 0)
            {
                Console.WriteLine("{0} {1} destroyed!", Type, Identifier);
                status = Spaceship.Status.Destroyed.ToString();
                Console.WriteLine("{0}'s new energy is {1}, status is {2}", Type, Energy, status);
                Environment.Exit(0);
            }
        }

        public enum Status
        {
            Dock,
            Destroyed,
            Fly,
        }
    }
    interface IAttack
    {
        void toAttack();
    }
    interface IMove
    {
        void Move();
    }
}
