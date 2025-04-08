using System.Runtime.CompilerServices;

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
        private static void Move(string[] args)
        {
            /*int movement += 1;
            //foreach(n in movement)
            {
                movement.Add(ToRoman());    
            }
            */
        }

        //Propriedade Cost
        public class Cost
        {
           // public float X => 90;
        }

        


    }
}
