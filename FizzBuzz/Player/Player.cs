using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineLogicPuns.FizzBuzz
{
    public  class Player
    {
        protected string _name;
        private IPlayerStartegy _playerStrategy;
        protected IPrinter _printer;

        public Player(IPrinter printer, string name, IPlayerStartegy playerStartegy)
        {
            _printer = printer;
            _name = name;
            _playerStrategy = playerStartegy;
        }


        public string TakeTurn(int number)
        {
           return  _playerStrategy.GetRule(number);
        }

        public void Print(string text)
        {
            _printer.Print(text);
        }
    }
}
