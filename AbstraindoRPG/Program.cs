using System;
using AbstraindoRPG.src.Entities;

namespace AbstraindoRPG
{

    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 469, 749 , 72 , 72);
            Ninja ninja = new Ninja("Wedge", 42, "Ninja", 292 , 574 , 89 , 89);
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 325 , 601 , 474, 482);
            Blackwizard blackwizard = new Blackwizard("Topapa", 42, "Black Wizard", 106 , 385 , 611 , 641);

            Console.WriteLine(arus);
            Console.WriteLine(ninja);
            Console.WriteLine(wizard);
            Console.WriteLine(blackwizard);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(1));     
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(blackwizard.Attack());      
        }
    }
}