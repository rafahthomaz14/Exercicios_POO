public class Funcionarios : Usuario{
    public string Cpf { get; set; }
    public string Cargo { get; set; }

    public Funcionarios(string login, string senha) : base(login, senha)
    {
        ReferenceEquals(Login, login);
        ReferenceEquals(Senha, senha);
    }

}