﻿using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Calcula Poupança");

        double investimento = 1000;

        for(int mes = 1; mes<=12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);
        }

        Console.WriteLine("Tecle algo para sair.");
        Console.ReadLine();
    }
}
