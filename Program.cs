using System;
using System.Runtime.Intrinsics;

namespace Calculadora{

class Program{

    static void Main (string[] args){
      Menu();

    }

    static void Menu(){
        Console.WriteLine("Escolha a operação que deseja realizar: ");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");


        short choice = short.Parse(Console.ReadLine());

        switch (choice){
            case 1: Soma();
            break;

            case 2: Subtracao();
            break;

            case 3: Multiplicacao();
            break;

            case 4: Divisao();
            break;

            case 5: System.Environment.Exit(0);
            break;

            default: 
            Console.WriteLine("Selecione uma das opções");
            Menu();
            break;

        }

        Console.Clear();
    }

    static void Soma(){

        Console.WriteLine("Digite o 1º valor: ");
        double v1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o 2º valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double res = v1 + v2;

        Console.WriteLine("O resultado da Soma é {0}",res );
        Console.ReadKey();
        Menu();

    }

    static void Subtracao(){

        Console.WriteLine("Digite o 1º valor: ");
        double v1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o 2º valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double res = v1 - v2;

        Console.WriteLine("O resultado dessa operação é {0}",res );
        Console.ReadKey();
        Menu();

    }

    static void Multiplicacao(){

        Console.WriteLine("Digite o 1º valor: ");
        double v1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o 2º valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double res = v1 * v2;

        Console.WriteLine("O resultado da operação é {0}",res );
        Console.ReadKey();
        Menu();

    }

    static void Divisao(){

        Console.WriteLine("Digite o 1º valor: ");
        double v1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o 2º valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double res = v1 / v2;

        Console.WriteLine("O resultado da operação é {0}",res );
        Console.ReadKey();
        Menu();

    }
}
}
