using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class CarPark
    {


        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        List<string> veiculos = [];


        public CarPark(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
    

        public decimal ValorEstacionamento(int horasEstacionado)
        {
            decimal total = (horasEstacionado * precoPorHora) + precoInicial;
            return total;

        }
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"Adicionado placa {placa}");
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja remover:");
            string? placa = Console.ReadLine();

            if (!veiculos.Contains(placa))
            {
                Console.WriteLine($"Placa {placa} não consta na lista de cadastro.");
                return;
            }

            Console.WriteLine("Informe a quantidade de horas que o veículo permaneceu no estacionamento:");
            int horasEstacionado = Convert.ToInt32(Console.ReadLine());
            decimal total = ValorEstacionamento(horasEstacionado);
            veiculos.Remove(placa);
            Console.WriteLine($"Veículo de placa {placa} removido com sucesso! O valor total do estacionamento é de: R${total}");


        }
        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
            }
            else
            {
                Console.WriteLine("Veículos Cadastrados:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }

        }

        public void Encerrar()
        {
            Console.WriteLine("Programa encerrado com sucesso!");
            Environment.Exit(0);
        }

    }
}



