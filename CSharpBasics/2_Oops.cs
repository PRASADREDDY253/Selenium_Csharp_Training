using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
   
        // OOPs -> Object
        // Class -> Fruit,              Vehicle  ->Attributes/behaviours/property/fields ->color,weight,shape
        //Methods//actions->drive,carry,
        // Object ->Apple,Mango,Banana    Car,Bus,Bycle,Train,Aeroplane

    //Access modifier ->private,public,protected,internal
    //En + capsulation
    //Inheritance ->Parent/Base/Super ----- Child/Derived/Sub
    //Polymorphism poly->many morph->shapes //
    public class Vehicle
    {
        //attributes
        private string color;   //field
        private double weight; //filed

        // Properties 
        public string Color  //Propertie
        {
            get { return color; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        //public double Weight { get; set; }
        //constructors
        public Vehicle()  //default constructor
        {
            Console.WriteLine("constructor");
        }
        public Vehicle(string color, double weight) //parammeterized construcor
        {
            Console.WriteLine("Overloaded constructor");
            this.color = color;
            this.Weight = weight;
        }
       

        //Methods/actions
        public void drive()
        {
            Console.WriteLine("Result:"+color+" "+weight);
        }
        private void Carry()
        {
            Console.WriteLine("carrying");
        }
    }
    public class AirVehilce:Vehicle
    {
        private double attitude;
        public double Attitude
        {
            get { return attitude; }
            set { attitude = value; }
        }

        public AirVehilce(double attitude,string color, double weight):base(color,weight) //Constructor chaining
        {
            this.Attitude= attitude;
        }
        public void vehileDetails()
        {
            Console.WriteLine("Details:"+Color+" "+Weight+ " "+Attitude);
        }

    }
    internal class MyClass
    {
        public static void Main3()
        {
            //Vehicle car = new Vehicle("black",200.0);
            ////car.drive();
            //Console.WriteLine(car.Color);
            //Console.WriteLine(car.Weight);
            ////car.Color = "red";
            //car.Weight = 500;
            //Console.WriteLine(car.Weight);
            //car.drive();

            AirVehilce aeroplane=new AirVehilce(2000,"White",300.5);
            //aeroplane.color;
            //aeroplane.Attitude = 500;
            aeroplane.vehileDetails();

            

            //Vehicle bus=new Vehicle("Green",400);
            //bus.drive();
            //Vehicle bus = new Vehicle();
            //Console.WriteLine(car.weight);
            //Console.WriteLine(bus.weight);
            //Console.WriteLine(car.color);


        }
       
        
    }

   

}
