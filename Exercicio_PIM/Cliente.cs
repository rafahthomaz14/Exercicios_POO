public class Cliente : Cadastro
{
    public string cpf { get; set; }
    public string endereco { get; set; }

    public Cliente(int codigo, string nome, string telefone, string email, string cpf, string endereco) : base(codigo, nome, telefone, email)
    {
        cpf = cpf;
        endereco = endereco;
    }

    public override void RealizarPedido()
    {
        // Lógica para realizar um pedido
        Console.WriteLine("Pedido realizado por {0}", Nome);
    }
}
