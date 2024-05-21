public class Fornecedor : Cadastro {

        public string Tabelapreco { get; set; }
        public string Cnpj { get; set; }
        public object InsumosCadastrados { get; private set; }

        List<Insumos> Insumos { get; set; }

        public Fornecedor(string tabelapreco, string cnpj, int codigo, string nome, string telefone, string email, string senha) :base(codigo, nome, telefone, email, senha)
        {
            Tabelapreco = tabelapreco;
            Cnpj = cnpj;
        }

        public void CadastrarInsumo(Insumos novoInsumo)
        {

                // Verificar se o insumo já está cadastrado
                if (Insumos.Contains(novoInsumo))
                {
                    Console.WriteLine("O insumo {0} já está cadastrado para o fornecedor {0}.", novoInsumo.Nome, Nome);
                    return;
                }

                // Realizar validações dos dados do insumo
                if (string.IsNullOrEmpty(novoInsumo.Nome) || novoInsumo.Preco <= 0 || novoInsumo.QuantidadeEstoque < 0) //no caso nao deixa cadastrar um insumo que tenha um nome vazio / preço negativo / quantidade negativa
                {
                    Console.WriteLine("Dados do insumo inválidos.");
                    return;
                }

                // Adicionar o novo insumo à lista de insumos cadastrados
                Insumos.Add(novoInsumo);

                // Insumos cadastrado

                Console.WriteLine("Insumo {0} cadastrado com sucesso para o fornecedor {0}.", novoInsumo.Nome, Nome);

        }
     }