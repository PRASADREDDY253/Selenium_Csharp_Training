// See https://aka.ms/new-console-template for more information
using CSharpBasics;
using System;
using System.Diagnostics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        
        static void Main2(string[] args)
        {
            Vehicle obj2=new Vehicle();
            //Data types
            //Variables
            char varName = 'a';
            int intvar = 2;
            float floatVar = 1.2f;
            double dbVar = 1.333;
            string strvar = "sai";
            bool bbolvar = true;

            //Type Casting
            //implicit casting
            float fl = intvar;
            //Console.WriteLine(fl);

            ////explicit casting
            //double newint = (double)floatVar;
            //Console.WriteLine(newint);

            //Console.WriteLine(varName);
            //Console.WriteLine(intvar);
            //Console.WriteLine(floatVar);
            //Console.WriteLine(dbVar);
            //Console.WriteLine(strvar);
            //Console.WriteLine(bbolvar);

            //functions
            //int res =AgeCalculae(2); //increase 2
            //Console.WriteLine("result is:"+res);
            //Method-Overloading
            //Console.WriteLine(AgeCalculae("32"));

            //Conditions
            //1.If,else,else,if
            int a = 20, b = 30, c = 12;
            if (a > b)
            {
                Console.WriteLine("a>b");
            }
            else if (a > c)
            {
                Console.WriteLine("a>c");
            }
            else if (a < b)
            {
                Console.WriteLine("None");
            }
            //ternary operation//shorthand if else
            Console.WriteLine((a > b) ? "a>b" : "none");
            //string resu=(a > b) ? "a>b" :"none";
            //2.switch
            int day = 55;

            switch (day)
            {
                case 1:
                    Console.WriteLine("day-1");
                    break;
                case 2:
                    Console.WriteLine("day-2");
                    break;
                case 3:
                    Console.WriteLine("day-3");
                    break;
                case 4:
                    Console.WriteLine("day-4");
                    break;
                case 5:
                    Console.WriteLine("day-5");
                    break;
                case 6:
                    Console.WriteLine("day-6");
                    break;
                default:
                    Console.WriteLine("nothing has selected");
                    break;
            }
            //loops
            //1.While loop
            //print the number 1-100
            //int i = 1;
            //while (i < 100)
            //{
            //    Console.Write(i + " ");
            //    i++;
            //}

            //2 do-while loop
            //do
            //{
            //    Console.Write(i + " ");
            //    i++;
            //}
            //while (i<100);
            //2.For loop 
            //for (int i = 1; i < 100; i++)
            //{
            //    Console.Write(i + " ");
            //}

            // Foreach loop->arrays,lists collections
            //array
            string[] names = { "sai", "prasad", "tej", "xxxx" }; //names[0],names[1],n
            int[] intarr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            for (int i = 0; i < names.Length; i++)
            {
                if (i==2)
                {
                    Console.WriteLine(names[i]);
                }
                
            }
            foreach (var item in intarr)
            {
                Console.WriteLine(item);
            }


            //OOPs->Class,Object,Inheritance,Encapsulation,Polymorphism
        }

        public static int AgeCalculae(int increm)
        {
            Console.WriteLine("enter age");
            string agestr = Console.ReadLine();
            int age = Convert.ToInt32(agestr);
            int result = age + increm;
            //Console.WriteLine(age+ increm);
            return result;
        }
        public static int AgeCalculae(string increm)
        {
            Console.WriteLine("enter age");
            string agestr = Console.ReadLine();
            int age = Convert.ToInt32(agestr);
            int result = age + Convert.ToInt32(increm);
            //Console.WriteLine(age+ increm);
            return result;
        }
    }
}
