public class ItemPedido{
    public int Id { get; set; }
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }
    public double PrecoUnitario { get; set; }

    public ItemPedido(int id, Produto produto, int quantidade, double precoUnitario)
    {
        Id = id;
        Produto = produto;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
    }

    // CONSTRUTOR CRIADO PARA REPRESENTAR OS ITENS NO CLIENTE
    public ItemPedido(int v1, string v2, int v3, double v4)
    {
    }

    public void AtualizarQuantidade(int novaQuantidade)
    {
        if (novaQuantidade < Quantidade || novaQuantidade > Quantidade)
            this.Quantidade = novaQuantidade;
    }

}