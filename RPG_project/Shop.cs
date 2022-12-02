using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    public class Shop
    {
        public static int[] shop(int[] character, int maxHp, int maxMana)
        {
            Console.WriteLine("Witaj w moim sklepie!!!");
            Console.WriteLine("1 - heal 14k \t 2 - upAtac 20k \t 3 - upDef 12k \t 4 - upMana 15k \t 5 - Muszle - 5k \t 6 - Kryształ - 10k \t 7 - wyjdz");
            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return heal(character, maxHp);
                case 2:
                    return upAtac(character);
                case 3:
                    return upDef(character);
                case 4:
                    return upMana(character, maxMana);
                case 5:
                    return sMuszle(character);
                case 6:
                    return sKrysztal(character);
            }
            Console.WriteLine("Wychodzisz ze sklepu");
            return character;
        }


        public static int[] heal(int[] character, int maxHp)
        {
            Random rnd = new Random();
            int heal = rnd.Next(10, 25);
            Console.WriteLine(character[0]);
            if (character[4] >= 14)
            {
                Console.WriteLine("Płacisz 2 k");
                character[4] -= 14;
                if (character[0] + heal >= maxHp)
                {
                    Console.WriteLine("Masz max hp");
                    character[0] = maxHp;
                    return character;
                }
                else
                {
                    Console.WriteLine($"Uleczono cie o {heal} masz {character[0]}hp");
                    character[0] += heal;
                    return character;
                }
            }
            Console.WriteLine("Nie stac sie");
            return character;
        }
        public static int[] upMana(int[] character, int maxMana)
        {
            Random rnd = new Random();
            int mana = rnd.Next(10, 25);
            Console.WriteLine(character[0]);
            if (character[4] >= 15)
            {
                Console.WriteLine("Płacisz 15 k");
                character[4] -= 15;
                if (character[3] + mana >= maxMana)
                {
                    Console.WriteLine("Masz max many");
                    character[3] = maxMana;
                    return character;
                }
                else
                {
                    Console.WriteLine($"Uleczono cie o {mana} masz {character[3]} mana");
                    character[3] += mana;
                    return character;
                }
            }
            Console.WriteLine("Nie stac sie");
            return character;

        }
        public static int[] upAtac(int[] character)
        {
            if (character[4] >= 20)
            {
                Console.WriteLine($"Twoj atak zwiekszyl sie o 5, wydajesz 20 kromers i teraz masz {character[1]}");
                character[4] -= 20;
                character[1] += 5;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczajaco kromers");
            }
            return character;
        }

        public static int[] upDef(int[] character)
        {
            if (character[4] >= 12)
            {
                Console.WriteLine($"Twoja zbroja zwiekszyla sie o 5, wydajesz 12 kromers i teraz masz {character[2]}");
                character[4] -= 12;
                character[2] += 5;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczajaco kromers");
            }
            return character;
        }

        public static int[] sMuszle(int[] character)
        {
            if (character[5] >= 1)
            {
                character[5] -= 1;
                int s = 5;
                Console.WriteLine($"Sprzedałeś 1 kryształ i dostałeś {s} kromers");
                character[4] += s;
            }
            else
            {
                Console.WriteLine("Nie masz muszli");
            }
            return character;
        }

        public static int[] sKrysztal(int[] character)
        {
            if (character[6] >= 1)
            {
                character[6] -= 1;
                int s = 10;
                Console.WriteLine($"Sprzedałeś 1 kryształ i dostałeś {s} kromers");
                character[4] += s;
            }
            else
            {
                Console.WriteLine("Nie masz kryształów");
            }
            return character;
        }
    }
}