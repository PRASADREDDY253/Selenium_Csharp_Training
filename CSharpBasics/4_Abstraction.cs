using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
   
        //abstraction->hiding some details and provide requied inforamtion
        //1.Abstarct class -> We cannot create objects/instance,
        // 2.Abstract method -> It does not have any body->Body provided by derived class
    
    abstract class Animal2
    {

        public abstract void Sleep();
        public void Walk()
        {
            Console.WriteLine("Walking");
        }      

    }
    class Elephant:Animal2
    {
        public override void Sleep()
        {
            Console.WriteLine("ELephant sleeping");
        }
    }
    class Lion : Animal2
    {
        public override void Sleep()
        {
            Console.WriteLine("Lion sleeping");
        }
    }
    class MyClass2
    {
        public static void Main5()
        {
            Elephant elephant=new Elephant();
            elephant.Sleep();
            elephant.Walk();
        }

    }
}
