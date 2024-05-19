public class Gerente:Funcionario{
    public double Bonificacao{get;set;}

    public Gerente(string Nome, string CPF, double Bonificacao) : base (Nome,CPF){
        this.Nome = Nome;
        this.CPF = CPF;
        this.Bonificacao = Bonificacao;
    }

    public override double CalcularSalario(){
        return Bonificacao + (6*SalarioMinimo);
    }
}