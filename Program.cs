using Estacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;


decimal precoInicial = 0;
decimal precoPorHora = 0;
int option = default;
bool menu = true;


Console.WriteLine("Bom dia, bem vindo ao estacionamento!");
Console.WriteLine("Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

CarPark Estacionamento = new(precoInicial, precoPorHora);

while (menu)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            Estacionamento.AdicionarVeiculo();
            break;

        case 2:
            Estacionamento.RemoverVeiculo();
            break;

        case 3:
            Estacionamento.ListarVeiculos();
            break;

        case 4:
            Estacionamento.Encerrar();
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}
