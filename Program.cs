﻿using System;
using System.Collections.Generic;
namespace FirstClass
{
    class Program
    {   
        
        static void Main(string[] args)
        {
           /*  foreach (int number in generadorFibonnaci(10))
            {
                Console.WriteLine(number);
            }
            */


              IEnumerable<int> mysequence = GeneratorSequence();
            /*Console.WriteLine("press key");
            Console.ReadKey();  */
            int i = 0;
            foreach (var item in mysequence)
            {
                if(i==10){
                   break;     
                }
                Console.WriteLine(item);
                i++;
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
        public static IEnumerable<int> GeneratorSequence(){
            int value1 = 0;
            Console.WriteLine("first line");
            yield return 10;    

            Console.WriteLine("second line");
            yield return 20;    

            while(value1 < 2){
                Console.WriteLine("abase line");
                yield return 1000;        
                value1++;

                
                Console.WriteLine("local var:"+value1);
                Console.WriteLine("bbase line");
                yield return 2000;     
                value1++;   
                Console.WriteLine("local var:"+value1);
                Console.WriteLine("cbase line");
                yield return 3000;     
                value1++;
                Console.WriteLine("local var:"+value1);
                Console.WriteLine("dbase line");
                yield return 4000;     
                value1++;
                Console.WriteLine("local var:"+value1);
                Console.WriteLine("ebase line");
                yield return 5000;     
                value1++;
            }


            Console.WriteLine("third line");
            yield return 30;    
            Console.WriteLine("forth line");
            yield return 40;    


        }

    }
}
