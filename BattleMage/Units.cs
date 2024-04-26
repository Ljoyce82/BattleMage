namespace BattleMage
{
    internal class Unit
    { 
        private int currentHP;
        private int maxHP;
        private int attackPower;
        private int healPower;
        private string unitName;
        private Random random;
        public int Hp { get { return currentHP;  } }
        
        public string UnitName { get { return unitName; } }

        public bool isDead { get { return currentHP <= 0; } }


        public Unit(int maxHP, int attackPower, int healPower, string unitName)
        {
            this.maxHP = maxHP; ;
            this.currentHP = maxHP;
            this.attackPower = attackPower;
            this.healPower = healPower;
            this.unitName = unitName;
            this.random = new Random();
        }

        public void Attack(Unit unitToAttack)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int randDamage = (int)(attackPower * rng);
            unitToAttack.TakeDamage(randDamage);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(unitName +  " attacks " + unitToAttack.unitName + " and deals " + randDamage + " damage! ");
            Console.ResetColor();
        }

        public void TakeDamage(int damage)
        {
            currentHP -= damage;

            if (isDead)
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(UnitName + " has been defeated! ");
                Console.ResetColor();
        }

        public void Heal()
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int heal = (int)(rng * healPower);
            currentHP = heal + currentHP > maxHP ? maxHP : currentHP + heal;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(UnitName + " heals " + heal);
            Console.ResetColor();
        }
    }
}