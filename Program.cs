using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
          //  PizzaBuilder pizzaB = new PizzaItalianaBuilder();
           // PizzaBuilder pizzaB = new PizzaLightBuilder();
            PizzaBuilder pizzaB = new PizzaMuzzarellaBuilder();

            Pizza pizza= pizzaB.BuildPizza();


            Console.WriteLine(pizza.ToString());
            Console.ReadLine();
        }
    }
}
