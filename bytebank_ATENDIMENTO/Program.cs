﻿using bytebank.Modelos.ADM.Funcionarios;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_GeradorChavePix;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

new ByteBankAtendimento().AtendimentoCliente();

/*
Console.WriteLine(GeradorPix.GetChavePix());

List<string> listaDeChaves = GeradorPix.GetChavesPix(10);

foreach (string chave in listaDeChaves)
{
    Console.WriteLine(chave);
}
*/
/*
public class Estagiario : Funcionario
{
    public Estagiario(double salario, string cpf) : base(salario, cpf)
    {
    }

    public override void AumentarSalario()
    {
        throw new NotImplementedException();
    }

    protected override double getBonificacao()
    {
        throw new NotImplementedException();
    }
}
*/