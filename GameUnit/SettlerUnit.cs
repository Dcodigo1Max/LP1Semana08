namespace GameUnit
{
    public class SettlerUnit : Unit // Heranca!!
    {
        

        public SettlerUnit() : base(1, 3)
        {                                                        // Unit(int, int)
            

        }

        public override float Cost
        {
            get
            {
                return 5;
            }
        }

    }

}