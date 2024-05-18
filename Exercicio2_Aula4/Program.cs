using System;
using System.Collections.Generic;

public class Program{

    public static void Main(string[] args){

        
        Consultor consultor = new Consultor("João", "123.456.789-00", 50, 40);
        Vendedor vendedor = new Vendedor("Maria", "987.654.321-00", 0.05, 100);
        Gerente gerente = new Gerente("Carlos", "111.222.333-44", 500);


        Console.WriteLine("Nome: {0}\nCPF: {1}\nRecebe: {2}",consultor.Nome,consultor.CPF,consultor.CalcularSalario());
        Console.WriteLine();
        Console.WriteLine("Nome: {0}\nCPF: {1}\nRecebe: {2}",vendedor.Nome,vendedor.CPF,vendedor.CalcularSalario());
        Console.WriteLine();
        Console.WriteLine("Nome: {0}\nCPF: {1}\nRecebe: {2}",gerente.Nome,gerente.CPF,gerente.CalcularSalario());

        
    }
}
