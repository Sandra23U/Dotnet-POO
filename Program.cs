using System;
using System.Collections.Generic;
using System.Linq;
using dotnet___poo.src.Entities;

namespace dotnet___poo
{
    class Program
    {
        static void Main(string[] args)
        {
            // criação dos heróis com suas características (instanciando um objeto)
            Knigth arus = new Knigth("Arus", 23, "Knigth");
            Wizard wizard = new Wizard("Jennica", 23, "Write Wizard");
            Ninja wedge = new Ninja("Wedge", 24, "Ninja");
            Black topapa = new Black("Topapa", 24, "Black");           
            
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(topapa.Attack());
        }   
    }
}
