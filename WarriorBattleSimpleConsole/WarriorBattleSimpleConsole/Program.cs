using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorBattleSimpleConsole.Logika;

namespace WarriorBattleSimpleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior ivo = new Warrior("Ivo", 500, 100, 50);
            Warrior mirko = new Warrior("Mirko", 500, 100, 50);

            Battle.StartFight(ivo, mirko);

            Console.ReadLine();
        }
    }
}
