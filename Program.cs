using System;
using System.Collections.Generic;
namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int number in generadorFibonnaci(10))
            {
                Console.WriteLine(number);
            }

        }
        public static List<int> generadorFibonnaci(int limit){
            List<int> fibonacci = new List<int>();
            fibonacci.Add(0);
            fibonacci.Add(1);
            for (int i = 1; i < limit;  i++ ){
                int auxiliarVar=fibonacci[i-1] ;
                int auxiliarVar2=fibonacci[i];
                int auxiliarVar3=auxiliarVar + auxiliarVar2;                
                fibonacci.Add(auxiliarVar3);               
            }

            return fibonacci ; 
            
        } 

    }
}
