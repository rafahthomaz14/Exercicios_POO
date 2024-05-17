using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {

        // Criando instâncias de cada animal
        Gato gato = new Gato();
        gato.Nome = "Bolinha";
        gato.Raca = "Siamês";
        gato.Idade = 3;
        Console.WriteLine(gato.Nome);
        Console.WriteLine(gato.Raca);
        Console.WriteLine(gato.Idade);
        gato.EmitirSom();

        Console.WriteLine();

        Cachorro cachorro = new Cachorro();
        cachorro.Nome = "Rex";
        cachorro.Raca = "Labrador";
        cachorro.Vacinacao = false;
        Console.WriteLine(cachorro.Nome);
        Console.WriteLine(cachorro.Raca);
        Console.WriteLine(cachorro.Vacinacao);
        cachorro.EmitirSom();

        Console.WriteLine();

        Canario canario = new Canario();
        canario.Nome = "Leo";
        canario.Raca = "Canário";
        canario.Cantando = true;
        Console.WriteLine(canario.Nome);
        Console.WriteLine(canario.Raca);
        Console.WriteLine(canario.Cantando);
        canario.EmitirSom();

    }
}

/* Possibilidades para fazer o Polimorfismo
    - Classe Regular(virtual/override)
    - Classe Abstrata(abstract/override)
    - Interface
*/






