using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace GameUnit
{
    public class Unit
    {
        private readonly int movement;

        //Health passou a ser virtual
        public virtual int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }




        //Metodo Move
        private static void Move(int movement)
        {
          movement = movement.Add(ToRoman);
          Console.WriteLine($"Units moved { movement.Add(ToRoman)}"); 
              
        }

        //Propriedade Cost
        public abstract float Cost()
        {
            get=>x=90;
        }
        
        
      
        


    }
}
