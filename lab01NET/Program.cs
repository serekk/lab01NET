using System;

namespace lab01NET
{
    class Program
    {

        static void Party(Osoba osoba)
        {
            if (osoba is Son)
            {
                Console.WriteLine("Ubieram garnitur");
                Console.WriteLine("Jem tylko rośliny");
            }
        }
        
        static void Main(string[] args)
        {
            Father ojciec = new Father();
            Son syn = new Son();
            
            ojciec.Eat();
            syn.Eat();
            
            ojciec.Wear();
            syn.Wear();
            
            Party(syn);
            
            
        }
        
        
    }
}