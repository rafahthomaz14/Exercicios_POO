public abstract class Cadastro {
    public int codigo { get; set; }
    public string nome { get; set; }
    public string telefone { get; set; }
    public string email { get; set; }

    public Cadastro(int codigo, string nome, string telefone, string email) {
        codigo = codigo;
        nome = nome;
        telefone = telefone;
        email = email;
    }

    public override void SalvarCadastro() {
        // Lógica para salvar o cadastro
        Console.WriteLine("Cadastro salvo com sucesso.");
    }

    public override void AtualizarCadastro(string novoNome, string novoEmail) {
        // Lógica para atualizar o cadastro
        nome = novoNome;
        email = novoEmail;
        Console.WriteLine("Cadastro atualizado com sucesso.");
    }

    public override void ExcluirCadastro() {
        // Lógica para excluir o cadastro
        Console.WriteLine("Cadastro excluído com sucesso.");
    }
}