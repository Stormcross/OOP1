using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorBattleSimpleConsole.Logika
{
    class Battle
    {
        //StarFIght
        //wwarior1 i warrior2
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1,warrior2)=="Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        //loop da se warriori bore dok jedan ne izgubi

        //GetAttackResoult
        //WarriorA, WarriorB
        public static string GetAttackResult
            (Warrior warriorA,Warrior warriorB)
        {
            double warrA_Att = warriorA.Attack();
            double warrB_Blk = warriorB.Block();

            double dmg2warrB = warrA_Att - warrB_Blk;

            if (dmg2warrB > 0)
            {
                warriorB.HP = warriorB.HP - dmg2warrB;
            }
            else dmg2warrB = 0;

            Console.WriteLine("{0} attacks {1} and deals {2} damage! ", warriorA.Name, warriorB.Name, dmg2warrB);
            Console.WriteLine("{0} has {1} health.\n ",warriorB.Name, warriorB.HP);

            if (warriorB.HP <= 0)
            {
                Console.WriteLine("{0} had Died and {1} is Victorius!\n", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else return "Fight again";
        }
        //Kalkulacije napada i obrane

        //oduzimanje napad od obrane

        //ako je bilo dmg, oduzmi dmg od hp

        //print out tko je napao koga, i za koliko

        //output promjene u HP

        //provjeri ako je HP dosao do 0 print upozorenje da je gotovo i zavrsi loop
    }
}
