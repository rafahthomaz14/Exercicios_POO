public class ControlePonto
{

    //usando true e false para entrada e saida
    public void RegistrarEntrada(Funcionario funcionario)
    {
        GerarComprovante(funcionario, true);
    }

    public void RegistrarSaida(Funcionario funcionario)
    {
        GerarComprovante(funcionario, false);
    }

    private void GerarComprovante(Funcionario funcionario, bool entrada)
    {
        /*

        ? operador ternario -- usado para if else

        string tipoEntrada;
        if(entrada){
            tipoEntrada = "Entrando";
        }
        else{
            tipoEntrada = "Saindo";
        }
        */

        string tipoEntrada = entrada ? "Entrando" : "Saindo";
        Console.WriteLine("\n" + funcionario.Nome + " Esta " + tipoEntrada + "\nData: " + DateTime.Now);
        Console.WriteLine("Cargo: " + funcionario.GetType().Name);
    }
}
