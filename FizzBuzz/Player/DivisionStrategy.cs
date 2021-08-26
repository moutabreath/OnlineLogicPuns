using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineLogicPuns.FizzBuzz
{
    class DivisionStrategy : IPlayerStartegy
    {
        public string GetRule(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 5 == 0)
            {
                return "FizzBuzz";
            }
            return number.ToString();
        }
    }
}
