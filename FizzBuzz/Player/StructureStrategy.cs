using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineLogicPuns.FizzBuzz
{
    public class StructureStrategy : IPlayerStartegy
    {
        public string GetRule(int number)
        {
            string numberString = number.ToString();
            if (numberString[numberString.Length - 1] == '4')
            {
                return "Bar";
            }
            if (numberString[0] == '6')
            {
                return "Foo";
            }
            return numberString;
        }
    }
}
