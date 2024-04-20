
using System;

namespace SnakeLadder
{
    internal class Player
    {
        static int start = 0;
        static int end = 100;

        public string? Name { get; set; }
        int initialPos;

        Player()
        {
            initialPos = 0;
        }

        public int RandomDice()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1,7);

            return dice;
        }
       
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Console.WriteLine(player1.RandomDice());
        }
    } 
}