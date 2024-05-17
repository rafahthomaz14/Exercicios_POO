using System;
public class Program{
    public static void Main(string[]args){

        Cliente Rafael = new Cliente();
        Rafael.Nome = "Rafael";
        Rafael.CPF = "111.111.111-12";
        Rafael.DataNascimento = "14/05/2000";
        Rafael.Vacinacao = true;
        Rafael.Credito = true;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}",Rafael.Nome,Rafael.CPF,Rafael.DataNascimento,Rafael.Vacinacao,Rafael.Credito);

        Console.WriteLine();

        Funcionario Leo = new Funcionario();
        Leo.Nome = "Jose Leo";
        Leo.CPF = "111.111.111-13";
        Leo.DataNascimento = "25/12/2000";
        Leo.Vacinacao = false;
        Leo.Matricula = "1111";
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}",Leo.Nome,Leo.CPF,Leo.DataNascimento,Leo.Vacinacao,Leo.Matricula);
    }

}
/*

- Criar um cliente e um funcionario
- Inserir Informações em todos os atributos ok
- Exibir as informações do cliente e funcionario que foram criados

*/