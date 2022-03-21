using System;
using System.Collections.Generic;

/*
 * Strategy is a behavioral design pattern that turns a set of behaviors 
 * into objects and makes them interchangeable inside original context object.
   The original object, called context, holds a reference to a strategy object
   and delegates it executing the behavior. In order to change
   the way the context performs its work, other objects may replace the currently
linked strategy object with another one.
 */

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new StategyIncreasedPromotions());
            context.CreatePromotionLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new StrategyDecreasedPromotion());
            context.CreatePromotionLogic();
        }
    }
}