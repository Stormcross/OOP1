using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorBattleSimpleConsole.Logika
{
    class Warrior
    {
        //ime, zdravlje, AttackMax, BlockMax
        private string name="Warrior";
        private double health;
        private double attackMax;
        private double blockMax;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double HP
        {
            get { return health; }
            set { health = value; }
        }
        public double AttackMax
        {
            get { return attackMax; }
            set { attackMax = value; }
        }
        public double BlockMax
        {
            get { return blockMax; }
            set { blockMax = value; }
        }
        //Random brojevi
        Random random = new Random();
        //Konstruktor
        public Warrior(string wName,double wHP, double wAttMax, double wBloMax)
        {
            Name = wName;
            HP=wHP;
            AttackMax = wAttMax;
            BlockMax = wBloMax;
        }
        //Attack
        //random od 1 do max
        public double Attack()
        {
            return random.Next(1, (int)AttackMax);
        }

        //Block
        //random od 1 do max
        public double Block()
        {
            return random.Next(1, (int)BlockMax);
        }
    }
}
