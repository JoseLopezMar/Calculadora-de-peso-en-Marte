namespace TecNM.Practica1.App;

using System;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Enums;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Services;

public static class Program {
    public static void Main(string[] args){
        float weight = 0;

        System.Console.WriteLine("\n+++++++++++++CALCULADORA DE PESO EN MARTE+++++++++++++");
        System.Console.WriteLine("\nPlease enter you weight in Kg");
        Single.TryParse(System.Console.ReadLine(), out weight);

        var person = new Person{weight = weight};
        var service = new GravityService();
        var manager = new GravityManager(service);

        Gravity gravity = manager.getGravity(person);

        System.Console.WriteLine($"\nThe weight of mass {person.weight} kg, in {gravity.GravityType} is equals {gravity.Index} Kg\n");
    }
}
