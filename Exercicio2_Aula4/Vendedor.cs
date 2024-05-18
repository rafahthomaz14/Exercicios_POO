public class Vendedor:Funcionario{
    public double Comissao{get;set;}
    public long NumeroVendas{get;set;}

    public Vendedor(string Nome,string CPF, double Comissao, long NumeroVendas): base (Nome,CPF){
        this.Nome = Nome;
        this.CPF = CPF;
        this.Comissao = Comissao;
        this.NumeroVendas = NumeroVendas;
    }

    public override double CalcularSalario(){
        return SalarioMinimo+(Comissao*NumeroVendas);
    }
        
}