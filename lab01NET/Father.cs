using System;

namespace lab01NET
{
    public class Father : Osoba
    {
        public override void Eat()
        {
            Console.WriteLine("Jem mięso");
        }

        public override void Wear()
        {
            Console.WriteLine("Ubieram garnitur");
        }
        
    }
}