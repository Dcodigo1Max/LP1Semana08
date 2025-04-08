using System.Runtime.CompilerServices;

namespace GameUnit
{
    public class Unit
    {
        private readonly int movement;
        public int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        private static void Move(string[] args)
        {
            /*int movement += 1;
            //foreach(n in movement)
            {
                movement.Add(ToRoman());    
            }
            */

        }



    }
}
