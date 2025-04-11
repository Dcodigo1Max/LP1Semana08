namespace GameUnit
{
    public class SettlerUnit : Unit // Heranca!!
    {
        

        public SettlerUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            /*
            get movement=> mov = 1;
            health=3;
            */

        }

        public override float Cost()
        {
            return 5;
        }

    }

}