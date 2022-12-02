using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    public class Event
    {
        public static int[] Bar(int[] character, int maxHp)
        {
            Console.WriteLine("Witaj w moim barze. . .");
            Console.WriteLine("1 - Head\t 2 - Tail\t 3 - Napój 15g\t dowolny klawisz - wyjdz");
            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return Head(character);
                case 2:
                    return Tail(character);
                case 3:
                    return napoj(character, maxHp);
                default:
                    return character;
            }
            Console.WriteLine("Wychodzisz z baru");
            return character;
        }

        public static int[] napoj(int[] character, int maxHp)
        {
            Random rnd = new Random();
            int heal = rnd.Next(10, 15);
            Console.WriteLine(character[0]);
            if (character[4] >= 15)
            {
                Console.WriteLine("Płacisz 15 g");
                character[4] -= 2;
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


        public static int[] Head(int[] character)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 2);
            int k = rnd.Next(1, 20);
            if (a == 0)
            {
                Console.WriteLine($"Heads, zdobywasz {k}");
                character[4] += k;

            }
            else if (a == 1)
            {
                character[4] -= k;
                Console.WriteLine($"Tails, Straciłeś {k} masz {character[4]} kromers");
            }
            return character;
        }


        public static int[] Tail(int[] character)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 2);
            int k = rnd.Next(1, 25);
            if (a == 0)
            {
                Console.WriteLine($"Tails, zdobywasz {k}");
                character[4] += k;

            }
            else if (a == 1)
            {
                character[4] -= k;
                Console.WriteLine($"Heads, Straciłeś {k} masz {character[4]} kromers");
            }
            return character;
        }        
    }
}
