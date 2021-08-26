using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineLogicPuns.FizzBuzz
{
    public class DivideCondition : ICondition
    {
        private int _factor;

        public DivideCondition(int factor)
        {
            _factor = factor;
        }

        public bool DoesMatch(int number)
        {
            return number % 3 == 0;
        }
    }
}
