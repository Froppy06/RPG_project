using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class GameInformation
    {
        public static void informations(int[] charcer, int round)
        {
            Console.WriteLine($"------------------- round - {round} -------------------");
            Console.WriteLine($"Twoje HP {charcer[0]} Attack {charcer[1]} Defense {charcer[2]} Magic {charcer[3]}  Kromer {charcer[4]} Ekwipunek: Muszle {charcer[5]} Kryształy {charcer[6]}");
            Console.WriteLine($"a - Adventure | s - Spels |w - Seller |e - Bar |p - Eksploracja |");
            Thread.Sleep(900); 
        }


    }
}
