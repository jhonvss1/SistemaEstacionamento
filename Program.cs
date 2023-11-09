using System;
using DesafioFundamentos1.Models;

decimal precoInicial = 0;
decimal precoHora = 0;
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

Console.Write("Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço pago por hora: ");
precoHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoHora);

bool execution = true;
while (execution)
{
    Console.WriteLine("Digite sua opção: ");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veiculos");
    Console.WriteLine("4 - Encerrar");
    int opcao = Convert.ToInt16(Console.ReadLine());
    switch(opcao)
    {
        case 1:
            estacionamento.AdicionarVeiculo();
            break;
        case 2:
            estacionamento.RemoverVeiculo();
            break; 
        case 3:
            estacionamento.ListarVeiculos();
            break;
        case 4:
            execution = false;
            break;
        
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
    Console.WriteLine("Clique uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou!");