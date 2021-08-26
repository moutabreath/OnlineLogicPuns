using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineLogicPuns.FizzBuzz
{
    public class FizzBuzz
    {
        Player[] _players;
        public FizzBuzz(Player[] players)
        {
            _players = players;
        }

        public void DisplayDivision(int [] array)
        {
            for (int i  = 0; i < array.Length; i++)
            {
                int playerTurn = i % 2;   
                string text = _players[playerTurn].TakeTurn(array[i]);
                _players[playerTurn].Print(text);
            }
        }

        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 23, 50, 60, 66,  };
            Player consoelPlayer = new Player(new ConsolePrinter(), "Cosnole", new DivisionStrategy());
            Player emailPlayer = new Player(new EmailPrinter(), "Email", new StructureStrategy());
            Player[] players = new Player[2];
            players[0] = consoelPlayer;
            players[1] = emailPlayer;
            FizzBuzz fizzBuzz = new FizzBuzz(players);
            fizzBuzz.DisplayDivision(array);

            _ = Console.ReadLine();

        }
    }
}
