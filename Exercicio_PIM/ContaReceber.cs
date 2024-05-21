using System;
using System.Collections.Generic;

public class ContaReceber
{
    public int Numero { get; private set; }
    public double ValorReceber { get; private set; }
    public double ValorRecebido { get; private set; }
    public DateTime DataReceber { get; private set; }
    private List<Movimentacao> movimentacoes;

    public ContaReceber(int numero, double valorReceber, DateTime dataReceber)
    {
        Numero = numero;
        ValorReceber = valorReceber;
        ValorRecebido = 0; // Inicialmente não foi recebido nenhum valor
        DataReceber = dataReceber;
        movimentacoes = new List<Movimentacao>();
    }

    public void AdicionarMovimentacao(Movimentacao movimentacao)
    {
        movimentacoes.Add(movimentacao);
    }

    public void ReceberPagamento(double valorPago)
    {
        if (valorPago <= 0)
        {
            Console.WriteLine("Valor de pagamento inválido.");
            return;
        }

        if (valorPago >= ValorReceber - ValorRecebido)
        {
            ValorRecebido += valorPago;
            Console.WriteLine("Conta número {0} recebida e paga", Numero);
        }
        else
        {
            Console.WriteLine($"Valor insuficiente para pagar a conta número {Numero}.");
        }
    }
}

