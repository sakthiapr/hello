using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
 
            A obj = new A();
            obj.WhoAreYou();
            B obj1 = new B();
            obj1.WhoAreYou();
            C obj2 = new C();
            obj2.WhoAreYou();
            A obj3 = new C();

            obj3.WhoAreYou();
            
            Console.ReadLine();
        }

    }

    class A
    {
        public virtual void WhoAreYou() { Console.WriteLine("I am an A"); }
    }
    class B : A
    {
        public override void WhoAreYou() { Console.WriteLine("I am a B"); }
    }
    class C : B
    {
        public new void WhoAreYou() { Console.WriteLine("I am a C"); }
    }
  

 
}
