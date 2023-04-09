using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

//overriding
//overloading

//Abstract ,Inheritance
namespace CSharpBasics
{
    internal class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    class WildAnimal
    {
        public void wildNature() { }
    }
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog says:bow bow bow");
        }

    }
    //class Lion : Animal, WildAnimal  //multiple Inheritance //biggest disadvantge with class
    //{ }

    class Program
    {
        public static void Main4(string[] args)
        {
            Animal animal= new Animal(); //creating animal object
            Animal dog=new Dog();  //dog object

            animal.Sound();
            dog.Sound();
            
        }
    }

}
