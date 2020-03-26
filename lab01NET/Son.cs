using System;

namespace lab01NET
{
    public class Son : Father
    {
        public new void Eat()
        {
            Console.WriteLine("Jem tylko rośliny");
        }

        public new void Wear()
        {
            Console.WriteLine("Ubieram dres");
        }

    }
}