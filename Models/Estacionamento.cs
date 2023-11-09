using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DesafioFundamentos1.Models
{
    public class Estacionamento
    {

        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string?> veiculos = new List<string?>();
        public Estacionamento (decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }
    

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para estacionar: ");
            string? placaVeiculo = Console.ReadLine();
            veiculos.Add(placaVeiculo); 
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover");
            string? placaRemover = Console.ReadLine();
            if (veiculos.Any(placaVeiculo => placaRemover.ToUpper() == placaVeiculo.ToUpper()))
            {
                int HorasEstacionadas = 0;
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                HorasEstacionadas = Convert.ToInt16(Console.ReadLine());
                decimal valorTotal = precoInicial + precoHora * HorasEstacionadas;
                
                veiculos.Remove(placaRemover);

                Console.WriteLine($"O veículo placa {placaRemover} foi removido e o preço total foi de R${valorTotal}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado em nossa base de dados. Confira se digitou corretamente.");
            }
        }

        public void ListarVeiculos()
        {
           if(veiculos.Any())
           {
                Console.WriteLine("Os veículos estacionados são: ");

                foreach(string? varredura in veiculos)
                {
                    Console.WriteLine($"{varredura}");
                }

           }
        }
    }
}