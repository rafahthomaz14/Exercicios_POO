public class Gerente : Usuario {

       public string Cpf { get; set; }

        // private List<Cadastro> cadastros = new List<Cadastro>();

        public Gerente(string login, string senha) : base(login, senha)
        {
            ReferenceEquals(Login, login);
            ReferenceEquals(Senha, senha);
        }

        public void GerenciarCadastros() 
        {
            Console.WriteLine("Gerenciamento cadastros.");

            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1. Criar cadastro");
            Console.WriteLine("2. Atualizar cadastro");
            Console.WriteLine("3. Excluir cadastro");
            Console.WriteLine("4. Voltar");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    string novoLogin = null;
                    string novaSenha = null;
                    string email = null;

                    Administrador admin = new Administrador(novoLogin, novaSenha, novaSenha);
                    admin.CriarLogin(novoLogin, novaSenha, email);
                    break;
                case 2:
                    AtualizarCadastro();
                    break;
                case 3:
                    ExcluirCadastro();
                    break;
                case 4:
                    Console.WriteLine("Voltando ao menu principal.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        public void AnalisarRelatorio()
        {
            
        }

    }