using System;
using System.Runtime.Intrinsics;

namespace Calculator{

class Program{

    static void Main (string[] args){
      Menu();

    }

    static void Menu(){
        Console.WriteLine("Choose the operation you want to carry out: ");
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Division");
        Console.WriteLine("5 - Exit");


        short choice = short.Parse(Console.ReadLine());

        switch (choice){
            case 1: Add();
            break;

            case 2: Sub();
            break;

            case 3: Mult();
            break;

            case 4: Div();
            break;

            case 5: System.Environment.Exit(0);
            break;

            default: 
            Console.WriteLine("Select one of the options.");
            Menu();
            break;

        }

        Console.Clear();
    }

    static void Add(){

        Console.WriteLine("Type the 1º value: ");
        double v1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Type the 2º value: ");
        double v2 = double.Parse(Console.ReadLine());

        double res = v1 + v2;

        Console.WriteLine("The result of operation is: {0}",res );
        Console.ReadKey();
        Menu();

    }

    static void Sub(){

        Console.WriteLine("Type the 1º value: ");
        double v1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Type the 2º value: ");
        double v2 = double.Parse(Console.ReadLine());

        double res = v1 - v2;

        Console.WriteLine("The result of operation is: {0}",res );
        Console.ReadKey();
        Menu();

    }

    static void Mult(){

        Console.WriteLine("Type the 1º value: ");
        double v1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Type the 1º value: ");
        double v2 = double.Parse(Console.ReadLine());

        double res = v1 * v2;

        Console.WriteLine("The result of operation is: {0}",res );
        Console.ReadKey();
        Menu();

    }

    static void Div(){

        Console.WriteLine("Type the 1º value: ");
        double v1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Type the 1º value: ");
        double v2 = double.Parse(Console.ReadLine());

        double res = v1 / v2;

        Console.WriteLine("The result of operation is: {0}",res );
        Console.ReadKey();
        Menu();

    }
}
}
