public class Consultor:Funcionario{
    public double ValorHora{get;set;}
    public long HorasTrabalhadas{get;set;}

    public Consultor(string Nome,string CPF,double ValorHora,long HorasTrabalhadas) : base (Nome,CPF){
        this.Nome = Nome;
        this.CPF = CPF;
        this.ValorHora= ValorHora;
        this.HorasTrabalhadas = HorasTrabalhadas;

    }

    public override double CalcularSalario(){
        return HorasTrabalhadas*ValorHora;
    }
}