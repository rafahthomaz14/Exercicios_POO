public class Movimentacao{
    public int Numero { get; set; }
    public double Valor { get; set; }
    public string Tipo { get; set; }
    public DateTime Data { get; set; }
    public TimeSpan Horario { get; set; }
    public string Descricao { get; set; }

    public void RegistrarMovimentacao()
    {
        this.Data = DateTime.Now; //mostra a 'data' da movimentação 
        this.Horario = TimeSpan.Zero; //mostra o 'horario' da movimentação 

        Console.WriteLine("Registrado com sucesso:");
        Console.WriteLine();
        Console.WriteLine("Numerp: {0}", Numero);
        Console.WriteLine("Valor: {0}", Valor.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Tipo: {0}", Tipo);
        Console.WriteLine("Data: {0}", Data);
        Console.WriteLine("Horario: {0}", Horario);
        Console.WriteLine("Descrição: {0}", Descricao);
    }
}