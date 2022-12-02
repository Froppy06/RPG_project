using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Spels
    {
        public static int[] SpelsBook(int[] character, int maxHp, int maxMana)
        {
            Console.WriteLine("a - Lecznie \t b - +Atack");
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            {
                case "a":
                    return Heal(character,maxHp,maxMana);
                case "b":
                    return Atack(character, maxMana);
                default:
                    return character;
            }
        }

        public static int[] Heal(int[] character, int maxHp, int maxMana)
        {
            if (character[3] >= 100)
            {
                character[0] = maxHp;
                character[3] -= 100;
                Console.WriteLine("Masz max hp");
                return character;
            }
            else
            {
                Console.WriteLine("Brak many");
            }

            return character;
        }

        public static int[] Atack(int[] character, int maxMana)
        {
            if (character[3] >= 150)
            {
                character[1] += 15;
                character[3] -= 100;
                Console.WriteLine("Zyskałęś +15 Atack");
                return character;
            }
            else
            {
                Console.WriteLine("Brak many");
            }

            return character;
        }




    }
}
