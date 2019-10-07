using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClass
{
    class Program
    {   
        
        static void Main(string[] args)
        {
            Coffe cup = PourCoffee();
            Console.WriteLine("Coffee is ready");
            Egg eggs = Fryeggs(2);
            Console.WriteLine("Eggs are ready");    
            Bacon bacon =FryBacon(3);
            Console.WriteLine("Bacon is ready");
            Toast toast = ToastBread(2)    ;
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");

            Console.WriteLine("Breakfast is ready");
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring Orange Juise");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>Console.WriteLine("Putting jam on the toast");
        
        private static void ApplyButter(Toast toast) => Console.WriteLine("Putting butter on the toast");
        
        private static Toast ToastBread(int slices)
        {
            for(int slice=0;slice <slices;slice++ ){
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
             Console.WriteLine("Start toasting");
             Task.Delay(300).Wait();
             Console.WriteLine("Remove toast from toaster");
             return new Toast();
        }
        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"Putting number of {slices} in the pan");
            Console.WriteLine("Cooking the first side of bacon");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon..");
            }
            Console.WriteLine("cooking the second side of bacon..");
            Task.Delay(3000).Wait();
            Console.WriteLine("put bacon on plate");
            return new Bacon();

        }

        private static Egg Fryeggs(int howMany)
        {
            Console.WriteLine("Warning the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on the plate");
            return new Egg();
        }

        private static Coffe PourCoffee()
        {
           Console.WriteLine("Pouring coffee");
           return new Coffe();
        }
    }


}
