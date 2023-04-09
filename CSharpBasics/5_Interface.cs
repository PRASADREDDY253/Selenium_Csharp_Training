using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
     // interface ->complete abstarct type,all are abstract methods,cannot object
    //all the memebsrs by default_>abstract and public
    interface IFruit
    {
       void Taste();
       void TypeOfFruit();
    }
    interface ISummerFruit
    {
        void Summer();
    }
    class Mango:IFruit, ISummerFruit //multiple interfaces
    {
        public void Summer()
        {
            Console.WriteLine("Summer Fruit");
        }

        public void Taste()
        {
            Console.WriteLine("Mango taste");
        }
        public void TypeOfFruit()
        {
            Console.WriteLine("MAngo");
        }
    }

    class Program2
    {
        public static void Main(string[] args)
        {
            IFruit obj= new Mango();
            obj.TypeOfFruit();
            obj.Taste();
            //obj.Summer();
        }
    }
}
