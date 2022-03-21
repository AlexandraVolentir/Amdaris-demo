using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    public class StategyIncreasedPromotions : IStrategy
    {
        public object PromitionLogic(object data)
        {
            var list = data as List<string>;
            list.Sort();
            return list;
        }
    }
}
