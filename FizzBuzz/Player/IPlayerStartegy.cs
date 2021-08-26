using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineLogicPuns.FizzBuzz
{
    public interface IPlayerStartegy
    {
        public string GetRule(int number);
    }
}
