using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_Object_Oriented_Program
{
    class MyClass
    {
        // Class members
        //Default values
        public string color = "red";        // public field
        private int maxSpeed = 200;          // private field (default if not declared)
        private string encapsulation;
        public MyClass()
        {

        }

        public MyClass(string colorInit, int maxSpeedInit)
        {
            color = colorInit;
            maxSpeed = maxSpeedInit;
        }
        public void fullThrottle()
        {
            Console.WriteLine($"Going {maxSpeed}MPH!");
        }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a new class, needs the initializing info
            MyClass withinits = new MyClass("Blue", 10);
            MyClass withouinits = new MyClass();
            //can call objects labeled public, if not declared public it isn't in scope
            Console.WriteLine(withinits.color);
            Console.WriteLine(withouinits.color);
            //can't access objects such as .maxSpeed due to being private

            //Also applies to methods
            withinits.fullThrottle();

            
            Console.ReadLine();
        }
    }
    
}
