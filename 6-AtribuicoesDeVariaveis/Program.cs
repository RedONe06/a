﻿using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 - Atribuições de variáveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);

        idade = 25; //não imprime
        
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
