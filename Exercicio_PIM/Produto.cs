public abstract class Produto {

    public int CodigoProduto { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int QuantidadeEstoque { get; set; }
    public double Preco { get; set; }

    public Produto(int codigoProduto, string nome, string descricao, int quantidadeEstoque, double preco)
    {
        this.CodigoProduto = codigoProduto;
        this.Nome = nome;
        this.Descricao = descricao;
        this.QuantidadeEstoque = quantidadeEstoque;
        this.Preco = preco;
    }

    public void AtualizarEstoque(int NovaQuantidade)
    {
        if (NovaQuantidade != QuantidadeEstoque)
        {
            int QuantidadeAnterior = QuantidadeEstoque;
            QuantidadeEstoque = NovaQuantidade;
            Console.WriteLine("Estoque do produto {0} atualizado para {1} unidades.", Nome, QuantidadeEstoque);
        }
    }

    public void DefinirPreco(double NovoPreco)
    {
        if (NovoPreco != Preco)
        {
            double PrecoAnterior = Preco;
            Preco = NovoPreco;
            Console.WriteLine("Preço do produto {0} alterado para R$ {1}", Nome, Preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
