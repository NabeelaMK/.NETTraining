using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Program
    {
        public interface Food
        {
            string getType();
        }

        public class Pizza : Food
        {
            public string getType()
            {
                return "Someone ordered Fast Food!";
            }
        }

        public class Cake : Food
        {
            public string getType()
            {
                return "Someone ordered a Dessert!";
            }

        }
        public class FoodFactory
        {
            public Food getFood(string order)
            {
                if (order.Equals("pizza", StringComparison.OrdinalIgnoreCase))
                {
                    return new Pizza();
                }
                else if (order.Equals("cake", StringComparison.OrdinalIgnoreCase))
                {
                    return new Cake();
                }
                else
                {
                    return null;
                }
            }

            static void Main(string[] args)
            {
                FoodFactory myFactory = new FoodFactory();
                Food food = myFactory.getFood(Console.ReadLine());
                Console.WriteLine("The factory returned class " + food.GetType().Name);
                Console.WriteLine(food.getType());
            }
        }
    }
}
