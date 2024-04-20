
using System;

namespace SnakeLadder
{
    internal class Player
    {
        static int start = 0;
        static int end = 100;

        public string? Name { get; set; }
        int initialPos;
        int currentPos;
        int count;
        Player()
        {
            initialPos = 0;
            currentPos = initialPos;
            count = 0;
        }

        public int RollDice()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            count++;
            return dice;
        }

        public void ChOption(int dice) { 
            Random rnd = new Random();
            int option = rnd.Next(1, 4);

            switch (option)
            {
                case 1:
                    Console.WriteLine("No Play\n" + this.currentPos);
                    break;

                case 2:
                    Console.WriteLine("Ladder");
                    currentPos += dice;
                    if(currentPos > 100)
                    {
                        currentPos -= dice;
                    }
                    Console.WriteLine("Position : " + this.currentPos);
                    Console.WriteLine("Count : " + this.count);
                    break;

                case 3:
                    Console.WriteLine("Snake");
                    currentPos -= dice;
                    if (currentPos <= 0)
                    {
                        currentPos = 0;
                    }

                    Console.WriteLine("Position : " + this.currentPos);
                    Console.WriteLine("Count : " + this.count);
                    break;
            }
        }

        static void Main(string[] args)
        {
            Player player1 = new Player();
            

            while(player1.currentPos < 100) {
                int dice = player1.RollDice();
                player1.ChOption(dice);
            }
            

        }
    }
}