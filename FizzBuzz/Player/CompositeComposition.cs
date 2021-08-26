using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineLogicPuns.FizzBuzz.Player
{
    public abstract class CompositeComposition
    {
        protected IList<ICondition> _conditions;

        public CompositeComposition(IList<ICondition> conditions)
        {
            _conditions = conditions;
        }

       public void AddContiion(ICondition condition)
       {

       }

        public bool DoesMatch(int number)
        {
            bool doesMatch = true;
            foreach (ICondition condition in _conditions)
            {
                doesMatch = Composite(condition);
            }
            return doesMatch;
        }

        public abstract bool Composite(ICondition condition);

    }
}
