using WarriorWars.Enum;


namespace WarriorWars.Equipment
{
    class Weapon
    {

        private const int GOOD_GUY_DAMAGE = 100;
        private const int BAD_GUY_DAMAGE = 100;

        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        // Constructor

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = GOOD_GUY_DAMAGE;
                    break;
                case Faction.BadGuy:
                    damage = BAD_GUY_DAMAGE;
                    break;
            }
        }
    }
}