using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineLogicPuns.FizzBuzz
{
    public class AndCondition : ICondition
    {
        protected IList<ICondition> _conditions;

        public AndCondition(IList<ICondition> conditions)
        {
            _conditions = conditions;
        }

        public bool DoesMatch(int number)
        {
            bool doesMatch = true;
            foreach(ICondition condition in _conditions)
            {
                doesMatch = doesMatch && condition.DoesMatch(number);
            }
            return doesMatch;
        }
    }
}
