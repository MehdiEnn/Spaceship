using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Exercice_Spaceships;

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


    

    





}
