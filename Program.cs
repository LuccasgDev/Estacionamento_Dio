using Projeto_Estacionamento.Models;

Estacionamento stc = new Estacionamento();

int valor_inicial = 0; 
int valor_por_hora = 0;

string menu_opcao;
string placa; 

int tempo_estacionato = 0;

int valor_a_pagar = 0;

do
{
    Console.WriteLine("Digite o valor inicial: ");
    valor_inicial = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o valor por hora: ");
    valor_por_hora = Convert.ToInt32(Console.ReadLine());
} while (valor_inicial <= 0 && valor_por_hora <= 0);

while (true)
{
    Console.WriteLine("======================");
    Console.WriteLine("= Estacionamento DIO =");
    Console.WriteLine("======================");
    Console.WriteLine("1 - Cadastrar Veiculo");
    Console.WriteLine("2 - Remover Veiculos");
    Console.WriteLine("3 - Listar Veiculos");
    Console.WriteLine("4 - Encerrar");
    menu_opcao = Console.ReadLine();
    
    switch (menu_opcao)
    {
        case "1": 
            Console.WriteLine("=====================");
            Console.WriteLine("= Cadastrar Veiculo =");
            Console.WriteLine("=====================");
            Console.WriteLine("Digite a placa do veiculo: ");
            placa = Console.ReadLine();
            stc.CadastrarVeiculo(placa);
            break;

        case "2":
            Console.WriteLine("===================");
            Console.WriteLine("= Remover Veiculo =");
            Console.WriteLine("===================");
            Console.WriteLine("Digite a placa do veiculo: ");
            placa = Console.ReadLine();
            stc.RemoverVeiculo(placa);
            Console.WriteLine("Digite o tempo que o veiculo ficou no estacionamento: ");
            tempo_estacionato = Convert.ToInt32(Console.ReadLine());
            valor_a_pagar = valor_inicial + (valor_por_hora*tempo_estacionato);
            Console.WriteLine($"Valor a pagar é R$ {valor_a_pagar} ");
            break;
            
        case "3":
            Console.WriteLine("=====================");
            Console.WriteLine("= Listar Veiculos =");
            Console.WriteLine("=====================");
            stc.ListarVeiculos();
            break;

        case "4": 
            Console.WriteLine("Encerrando o programa...");
            return;
    }
}