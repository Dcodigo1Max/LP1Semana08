namespace GameUnit
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }
    
        //Metodo public void
        public void Attack(Unit u)
        {   
            XP = ++XP;
            int dano = AttackPower + XP;

        }


        
    
    
    }
}

/*
Faz override de Health tal que esta seja igual à Health base + XP
Faz override de Cost, tal que retorne AttackPower + XP
Cria método public void Attack(Unit u) que incrementa o XP da própria unidade e aplica um dano igual a AttackPower na Health
da unidade atacada




*/