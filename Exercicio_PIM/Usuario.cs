public class Usuario:Cadastro{
     public string Login { get; set; }
    public string Senha { get; set; }

    public Usuario(string login, string senha)
    {
        Login = login;
        Senha = senha;
    }

    public void FazerLogout()
    {
        Console.WriteLine("O usuario {0} fez logout", Login);
    }

    public void AlterarSenha(string NovaSenha)
    {
        if (NovaSenha != Senha)
        {
            Senha = NovaSenha;
            Console.WriteLine("Senha do usuario {0} alterada com sucesso!", Senha);
        }
        else
        {
            Console.WriteLine("Escolha uma senha diferente.");
        }
    }

    public bool Autenticar(string login, string senha)
    {
        if (login == Login && senha == Senha)
        {
            Console.WriteLine("Usuário {0} autenticado com sucesso.", login);
            return true;
        }
        else
        {
            Console.WriteLine("Falha na autenticação.");
            return false;
        }
    }
}