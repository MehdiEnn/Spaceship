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
            List<Spaceship> vaisseaux = new List<Spaceship>();
            
            Spaceship spaceship = new Spaceship();
            vaisseaux.Add(spaceship);
            spaceship.Launch();
            spaceship.Attack();
            spaceship.Move();
            spaceship.Destruction();

            
            Battlestellar battlestellar = new Battlestellar();
            vaisseaux.Add(battlestellar);
            battlestellar.Launch();
            battlestellar.Attack();
            battlestellar.Move();
            battlestellar.Destruction();

            Entreprise entreprise = new Entreprise();
            vaisseaux.Add(entreprise);
            entreprise.Launch();
            entreprise.Attack();
            entreprise.Attack();
            entreprise.Attack();
            entreprise.Move();
            entreprise.Destruction();

        }
    }


    

    





}
