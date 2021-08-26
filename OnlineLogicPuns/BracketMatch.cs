using System.Collections;

namespace OnlineLogicPuns
{
    class BracketMatch
    {
        public static string BracketMatcher(string str)
        {

            Stack myStack = new Stack();
            int i = 0;
            while (i < str.Length)
            {
                // Console.WriteLine("STr at1 : "+ i + " "+ str[i]);
                if (str[i] == '(')
                {
                    myStack.Push(str[i]);
                    continue;
                }
                if (str[i] == ')')
                {
                    // Console.WriteLine("STr at 2: "+ i + " "+ str[i]);
                    if (myStack.Count == 0) { return "1"; }
                    myStack.Pop();
                }
                i++;
            }
            string result = myStack.Count == 0 ? "0" : "1";
            return result;

        }
    }
}
