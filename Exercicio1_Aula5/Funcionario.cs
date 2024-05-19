public abstract class Funcionario{
    public string Nome{get;set;}
    public string CPF{get;set;}

    public Funcionario(string Nome, string CPF){
        this.Nome = Nome;
        this.CPF = CPF;
    }
    
    protected const double SalarioMinimo = 1300;

    public abstract double CalcularSalario();
}