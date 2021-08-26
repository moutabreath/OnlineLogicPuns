using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineLogicPuns.FizzBuzz
{
    public class EmailPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("@ " + text);
        }
    }
}
