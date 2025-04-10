## Mermaid Diagram

```mermaid
classDiagram

class Program{
        Main
}

Program <|--Weapon
Program <|--Character


class Weapon{
    +power: float
    weapon(float power)
}
Weapon <|--sword

class sword {
    +BladeLenght: float
    AttackWithSword()
    Sword(float power, float bladeLength) : base(power)
}

Weapon <|--Gun

class Gun{
    +int Ammo
    Gun(float power, int ammo)  base (power)
    FireGun()
}


class Character{
    +Weapon protected
    +Name String 
    Fight()
}


Character <|--Enemy

class Enemy{
    Enemy (string name)
}

Character <|--Player

class Player{
    Player (string name)
}
