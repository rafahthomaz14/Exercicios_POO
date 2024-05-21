
public class ControleProducao{
    public int Numero { get; set; }
    public DateTime Data { get; set; }
    public TimeSpan Hora { get; set; }
    public int Quantidade { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataConclusao { get; set; }
    public string Status { get; set; }

    public void IniciarProducao()
    {

        DataInicio = DateTime.Now; // Define a data de inicio da produção momento atual

        // horario do inicio da procução
        var parse = TimeSpan.Parse("07:20:59");

        Status = "Em andamento"; // Atualiza o status para "Em andamento"

        Console.WriteLine("Produção iniciada com sucesso:");
        Console.WriteLine();
        Console.WriteLine("Número: {0}", Numero);
        Console.WriteLine("Data de inicio: {0}", DataInicio);
        Console.WriteLine("Horario de inicio: {0}:{1}:{2}", parse.Hours, parse.Minutes, parse.Seconds);
        Console.WriteLine("Status: {0}", Status);

    }

    public void ConcluirProducao()
    {
        DataConclusao = DateTime.Now;
        Status = "Concluído"; // Atualiza o status para 'Concluido'

        var parse = TimeSpan.Parse("16:50:24"); // horario do FIM da procução

        Console.WriteLine("Produção concluida com sucesso:");
        Console.WriteLine();
        Console.WriteLine("Número: {0}", Numero);
        Console.WriteLine("Data de Conclusão: {0}", DataConclusao);
        Console.WriteLine("Horario da Conclusão: {0}:{1}:{2}", parse.Hours, parse.Minutes, parse.Seconds);
        Console.WriteLine("Status: {0}", Status);
    }
}
