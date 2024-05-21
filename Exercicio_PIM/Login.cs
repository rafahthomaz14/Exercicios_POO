public class Login {

            public string ContaLogin { get; set; }
            public string Senha {  get; set; }

            public Login(string login, string senha)
            {
                this.ContaLogin = login;
                this.Senha = senha;
            }


            public bool FazerLogin(string login, string senhaDigitada)
            {
                if (login == ContaLogin || senhaDigitada == Senha) 
                {
                    // Verifica se o login e senha existe

                    Usuario usuario = new Usuario(login, senhaDigitada);

                    usuario.Autenticar(login, senhaDigitada);
                    Console.WriteLine("Login bem sucedido");
                    return true;
                }
                else
                {
                    Console.WriteLine("Login ou senha incorretos");
                    return false;
                }
            }


            //Simulando a recuperação de senha
            //usuari.RecuperarSenha("EXEMPLOEMAIL@OUTLOOK.COM")
        

            public void RecuperarSenha(string email)
            {
                Console.WriteLine("Um e-mail de recuperação de senha foi enviado para {0}", email);
            }


    }