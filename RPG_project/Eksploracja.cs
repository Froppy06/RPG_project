using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Eksploracja
    {
        public static int[] Place(int[] character)
        {
            Console.WriteLine("Postanowiłeś poeksplorować teren wokół ciebie, gdzie chcesz iść?");
            Console.WriteLine("1 - Las\t 2 - Blaża\t dowolny klawisz - wyjdz");
            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return Forest(character);
                case 2:
                    return Beach(character);
            }
            Console.WriteLine("Powracasz na przygode");
            return character;
        }

        public static int[] Forest(int[] character)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 2);
            int k = rnd.Next(1, 5);
            if (a == 0)
            {
                Console.WriteLine($"Znalazłeś kryształy: {k}");
                character[6] += k;

            }
            else if (a == 1)
            {
                Console.WriteLine($"Znalazłeś nic");
            }
            return character;
        }


        public static int[] Beach(int[] character)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 2);
            int m = rnd.Next(1, 10);
            if (a == 0)
            {
                Console.WriteLine($"Znalazłeś muszle: {m}");
                character[5] += m;

            }
            else if (a == 1)
            {
                Console.WriteLine($"Znalazłeś nic");
            }
            return character;
        }
    }
}
