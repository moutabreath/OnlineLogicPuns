using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineLogicPuns.FizzBuzz
{
    public interface ICondition
    {
        public bool DoesMatch(int number);
    }
}
