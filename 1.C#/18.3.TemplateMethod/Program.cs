/*
 The Template Method design pattern defines the skeleton of an algorithm in an operation,
deferring some steps to subclasses.
This pattern lets subclasses redefine certain steps of an algorithm without changing the algorithm‘s structure.
 
 */
using System;
namespace Template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Promotioning aA = new PromotionA();
            aA.TemplateMethod();
            Promotioning aB = new PromotionB();
            aB.TemplateMethod();
            // Wait for user
            Console.ReadKey();
        }
    }

    public abstract class Promotioning
    {
        public abstract void FirstStep();
        public abstract void SecondStep();
        // The "Template method"
        public void TemplateMethod()
        {
            FirstStep();
            SecondStep();
            Console.WriteLine("");
        }
    }

    public class PromotionA : Promotioning
    {
        public override void FirstStep()
        {
            Console.WriteLine("Promotion A did its first step....random filtering1");
        }
        public override void SecondStep()
        {
            Console.WriteLine("Promotion A did its second step.......random filtering2");
        }
    }

    public class PromotionB : Promotioning
    {
        public override void FirstStep()
        {
            Console.WriteLine("Promotion B did its first step......filtering 1");
        }
        public override void SecondStep()
        {
            Console.WriteLine("Promotion B did its second step.....filtering2");
        }
    }
}