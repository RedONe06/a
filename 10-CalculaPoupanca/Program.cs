﻿using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        double investimento = 1000;
        int mes = 1;

        while (mes <= 12)
        {
            investimento += (investimento * 0.005);
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);
            mes++;
        }
        
        Console.WriteLine("Tecle algo para sair.");
        Console.ReadLine();
    }
}

