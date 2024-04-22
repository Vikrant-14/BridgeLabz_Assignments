
using System;

namespace SnakeLadder
{
    internal class Player
    {
        static int startPos = 0;
        static int endPos = 100;

        public string? Name { get; set; }
        int initialPos;
        int currentPos;
        int dice;
        int count;

        Player()
        {
            initialPos = 0;
            currentPos = initialPos;
            count = 0;
        }

        Player(string name)
        {
            this.Name = name;
        }

        static Player()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Welcome to Snake and Ladder Game!!!");
            Console.WriteLine("====================================");
        }

        public int RollDice()
        {
            Random rnd = new Random();
            this.dice = rnd.Next(1, 7);
            this.count++;
            return this.dice;
        }

        public void ChOption()
        {
            Random rnd = new Random();
            int option = rnd.Next(1, 4);

            switch (option)
            {
                case 1:
                    Console.WriteLine("-----\nNo Play");
                    Console.WriteLine("Name of Player : " + this.Name);
                    Console.WriteLine("Position : " + this.currentPos);
                    Console.WriteLine("Count : " + this.count);

                    break;

                case 2:
                    Console.WriteLine("-----\nLadder");
                    currentPos += this.dice;

                    if (currentPos > endPos)
                    {
                        currentPos -= dice;
                    }

                    Console.WriteLine("Name of Player : " + this.Name);
                    Console.WriteLine("Dice : " + this.dice);
                    Console.WriteLine("Position : " + this.currentPos);
                    Console.WriteLine("Count : " + this.count);

                    if (this.currentPos == endPos)
                    {
                        return;
                    }

                    this.RollDice();
                    this.ChOption();

                    break;

                case 3:
                    Console.WriteLine("-----\nSnake");
                    currentPos -= dice;
                    if (currentPos <= startPos)
                    {
                        currentPos = startPos;
                    }

                    Console.WriteLine("Name of Player : " + this.Name);
                    Console.WriteLine("Dice : " + this.dice);
                    Console.WriteLine("Position : " + this.currentPos);
                    Console.WriteLine("Count : " + this.count);


                    break;
            }
        }


        public static int MenuDriven()
        {
            int choice = 0;

            Console.WriteLine("0. Enter Zero to Exit the Game.");
            Console.WriteLine("1. Enter One to Play the Game!!!");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input : Enter only numbers");
            }
           

            return choice;
        }

        public static string AcceptRecord()
        {
            Console.WriteLine("Enter player Name : ");
            string? name = Console.ReadLine();
            return name;
        }

        public static void PlayGame(Player player1, Player player2)
        {
            while (player1.currentPos < endPos && player2.currentPos < endPos)
            {
                player1.dice = player1.RollDice();
                player1.ChOption();

                if (player1.currentPos == endPos)
                {
                    break;
                }

                player2.dice = player2.RollDice();
                player2.ChOption();

                if (player2.currentPos == endPos)
                {
                    break;
                }

            }

            if (player1.currentPos == endPos)
            {
                Console.WriteLine("\n====================================");
                Console.WriteLine($"{player1.Name} is Winner!!!");
                Console.WriteLine("====================================\n");
            }
            else if (player2.currentPos == endPos)
            {
                Console.WriteLine("\n====================================");
                Console.WriteLine($"{player2.Name} is Winner!!!");
                Console.WriteLine("====================================\n");
            }


            Console.WriteLine($"Count of {player1.Name} is at {player1.currentPos} position with {player1.count} times dice rolled");
            Console.WriteLine($"Count of {player2.Name} is at {player2.currentPos} position with {player2.count} times dice rolled");
        }

        static void Main()
        {
            int choice = 0;
            while ( ( choice = MenuDriven() ) != 0 )
            {
                switch(choice)
                {
                    case 0: break;

                    case 1: 
                            Player? player1 = new Player( AcceptRecord() );

                            Player? player2 = new Player( AcceptRecord() );
                       
                            PlayGame( player1, player2 );
                        break;
                }

                Console.WriteLine( "\nDo you want to play again?" );
            }
        }
    }
}