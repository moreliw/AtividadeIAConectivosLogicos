using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha um conectivo lógico: ");
        Console.WriteLine("1. NOT");
        Console.WriteLine("2. AND");
        Console.WriteLine("3. OR");
        Console.WriteLine("4. XOR");
        Console.WriteLine("5. Bicondicional");
        Console.WriteLine("6. Implicação");

        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Conectivo escolhido: NOT\n");
                ImprimirTabelaVerdadeNOT();
                break;
            case 2:
                Console.WriteLine("Conectivo escolhido: AND\n");
                ImprimirTabelaVerdadeAND();
                break;
            case 3:
                Console.WriteLine("Conectivo escolhido: OR\n");
                ImprimirTabelaVerdadeOR();
                break;
            case 4:
                Console.WriteLine("Conectivo escolhido: XOR\n");
                ImprimirTabelaVerdadeXOR();
                break;
            case 5:
                Console.WriteLine("Conectivo escolhido: BICONDICIONAL\n");
                ImprimirTabelaVerdadeBicondicional();
                break;
            case 6:
                Console.WriteLine("Conectivo escolhido: IMPLICAÇÃO\n");
                ImprimirTabelaVerdadeImplicacao();
                break;
            default:
                Console.WriteLine("Escolha inválida.");
                break;
        }
    }

    static void ImprimirTabelaVerdadeNOT()
    {
        Console.WriteLine("Tabela Verdade para NOT:\n");
        Console.WriteLine(" A | NOT A (~)");
        Console.WriteLine("--------------");
        bool[] valores = { true, false };

        foreach (bool a in valores)
        {
            bool resultado = !a;
            Console.WriteLine($"{a} | {resultado}");
        }
        Console.WriteLine("--------------");
    }

    static void ImprimirTabelaVerdadeAND()
    {
        Console.WriteLine("Tabela Verdade para AND:\n");
        Console.WriteLine("   A | B | A AND B (^)");
        Console.WriteLine("----------------------");
        bool[] valores = { true, false };

        foreach (bool a in valores)
        {
            foreach (bool b in valores)
            {
                bool resultado = a && b;
                Console.WriteLine($"{a} | {b} | {resultado}");
            }
        }
        Console.WriteLine("----------------------");
    }

    static void ImprimirTabelaVerdadeOR()
    {
        Console.WriteLine("Tabela Verdade para OR:\n");
        Console.WriteLine("   A | B | A OR B (v)");
        Console.WriteLine("------------------------");
        bool[] valores = { true, false };

        foreach (bool a in valores)
        {
            foreach (bool b in valores)
            {
                bool resultado = a || b;
                Console.WriteLine($"{a} | {b} | {resultado}");
            }
        }
        Console.WriteLine("------------------------");
    }

    static void ImprimirTabelaVerdadeXOR()
    {
        Console.WriteLine("Tabela Verdade para XOR:\n");
        Console.WriteLine("    A | B | A XOR B (v exclusivo)");
        Console.WriteLine("---------------------------------");
        bool[] valores = { true, false };

        foreach (bool a in valores)
        {
            foreach (bool b in valores)
            {
                bool resultado = a ^ b;
                Console.WriteLine($"     {a} | {b} | {resultado}");
            }
        }
        Console.WriteLine("---------------------------------");
    }

    static void ImprimirTabelaVerdadeBicondicional()
    {
        Console.WriteLine("Tabela Verdade para Bicondicional:\n");
        Console.WriteLine("A | B | A ↔ B (↔)");
        Console.WriteLine("-------------------");
        bool[] valores = { true, false };

        foreach (bool a in valores)
        {
            foreach (bool b in valores)
            {
                bool resultado = (a && b) || (!a && !b);
                Console.WriteLine($"{a} | {b} | {resultado}");
            }
        }
        Console.WriteLine("-------------------");
    }

    static void ImprimirTabelaVerdadeImplicacao()
    {
        Console.WriteLine("Tabela Verdade para Implicação:\n");
        Console.WriteLine("A | B | A => B (=>)");
        Console.WriteLine("---------------------");
        bool[] valores = { true, false };

        foreach (bool a in valores)
        {
            foreach (bool b in valores)
            {
                bool resultado = !a || b;
                Console.WriteLine($"{a} | {b} | {resultado}");
            }
        }
        Console.WriteLine("---------------------");
    }
}
