using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Humanizer;

namespace GameUnit
{
    public abstract class Unit
    {
        private readonly int movement;

        //Health passou a ser virtual
        public virtual int Health { get; set; }

        public abstract float Cost{get;}

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }




        //Metodo Move
        private static void Move(int movement)
        {
          
          Console.WriteLine($"Units moved {movement.ToRoman()}"); 
              
        }

        //Propriedade Cost
        
        
      

        public  string NewCost()  
        {
            return Cost.ToString();
        }
        
      
        


    }
}
