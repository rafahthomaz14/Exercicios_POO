public class Insumos : Produto
{
    public Fornecedor Fornecedor { get; set; }

    public Insumos(Fornecedor fornecedor, int codigoProduto, string nome, string descricao, int quantidadeEstoque, double preco) : base(codigoProduto, nome, descricao, quantidadeEstoque, preco)
    {
        Fornecedor = fornecedor;
    }
}
