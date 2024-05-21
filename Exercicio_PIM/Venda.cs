public class Venda{
    public double ValorTotal { get; set; }
    public Cliente Cliente { get; set; }
    public List<Produto> Produtos { get; set; }

    public void ProcessarVenda()
    {
        // faz uma verificação para ver se tem produtos na lista
        if (Produtos != null && Produtos.Count > 0) // Se produtos é diferente de nulo E os produtos é maior que 0
        {
            // Valor da venda iniciado com 0
            ValorTotal = 0;

            // faz o calculo do valor total da venda somando os preços dos produtos
            foreach (var produto in Produtos)
            {
                ValorTotal += produto.Preco; // 
            }

            Console.WriteLine("Venda processada com sucesso para o cliente {0}.", Cliente.Nome);
            Console.WriteLine("Valor total da venda: R$ {0}", ValorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
        else
        {
            Console.WriteLine("Não há produtos para processar a venda.");
        }

    }
}