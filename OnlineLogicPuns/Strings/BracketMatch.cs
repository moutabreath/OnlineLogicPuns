using System.Collections.Generic;

namespace OnlineLogicPuns
{
    /**
    Valid Parentheses
        Given a string containing only three types of characters: '(', ')' and '*', write a function to check whether this string is valid. We define the validity of a string by these rules:

        Any left parenthesis '(' must have a corresponding right parenthesis ')'.
        Any right parenthesis ')' must have a corresponding left parenthesis '('.
        Left parenthesis '(' must go before the corresponding right parenthesis ')'.
        '*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string.
        An empty string is also valid.
        Examples:
        Input: "()"
        Output: true
        Input: "(*)"
        Output: true
        Input: "())*"
        Output: false
    */
    public class BracketMatch
    {
        public static bool isValid(string exp)
        {
            // Write your code here.
            if (exp == null || exp == "")
            {
                return true;
            }

            Stack<char> myStack = new Stack<char>();
            int i = 0;
            while (i < exp.Length)
            {
                if (exp[i] == '(' || exp[i] == '*')
                {
                    myStack.Push(exp[i]);
                    i++;
                    continue;
                }
                if (exp[i] == ')')
                {
                    Stack<char> temp = new Stack<char>();
                    while (myStack.Count != 0)
                    {                       
                        var top = myStack.Pop();
                        if (top == '(')
                        {
                            break;
                        }
                        temp.Push(top);
                        break;
                    }
                    while (temp.Count > 1)
                    {
                        myStack.Push(temp.Pop());
                    }
                    i++;
                    continue;
                }
                i++;
            }
            int numberOfAsterisk = 0;
            int numberOfBrackets = 0;
            if (myStack.Count > 0)
            {
                if (myStack.Pop() == '(')
                {
                    return false;
                }
            }
            while ( myStack.Count > 0)
            {
                char c = myStack.Pop();
                if (c == '*')
                {
                    numberOfAsterisk++;
                }
                if (c == '(')
                {
                    numberOfBrackets++;
                }
            }
            return numberOfBrackets <= numberOfAsterisk;
        }
    }
}
