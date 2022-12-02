using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class CharacterClass
    {

        public static int[] characterClassSelection()
        {
            // hp atack mana gold 
            while (true)
            {
                Console.WriteLine("From immemorial time, many creatures have walked the earth");
                Console.WriteLine("But everything must come to an end");
                Console.WriteLine("Choose your place in this world wisely");
                Console.WriteLine("Cesar - a \t Mark -b \t Adam -c \t Jonah -d");
                string inp = Console.ReadLine();
                if (inp == "a")
                {
                    int[] m = { 70, 20, 35, 300, 20, 0, 0 };
                    return m;
                }
                else if (inp == "c")
                {
                    int[] w = { 100, 40, 35, 50, 20, 0, 0 };
                    return w;
                }
                else if (inp == "d")
                {
                    int[] w = { 150, 25, 10, 150, 20, 0, 0 };
                    return w;
                }
                else if (inp == "b")
                {
                    int[] w = { 95, 30, 25, 175, 20, 0, 0 };
                    return w;
                }
                else
                {
                    Console.WriteLine("Brak takiej klasy");
                }
            }
        }
        //---------------------------------------------------------
        public static bool isAlive(int[] character)
        {
            if (character[0] <= 0)
                return false;
            return true;
        }
    }
}
