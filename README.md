Projeto Estacionamento
Descrição
Este projeto simula um sistema de estacionamento simples, permitindo que usuários cadastrem, removam e listem veículos. O sistema também calcula o valor a ser pago com base no tempo que o veículo ficou estacionado e nas tarifas definidas.

Funcionalidades
Cadastrar Veículo: Permite adicionar a placa de um veículo ao sistema.
Remover Veículo: Remove um veículo do estacionamento e calcula o valor a ser pago.
Listar Veículos: Exibe todas as placas cadastradas no estacionamento.
Encerrar o Programa: Fecha o aplicativo.
Estrutura do Código
O projeto é dividido em duas partes principais:

Classe Estacionamento: Gerencia a lista de veículos, incluindo métodos para cadastrar, remover e listar placas.
Menu Principal: Interage com o usuário, permitindo a escolha das operações a serem realizadas.
Classe Estacionamento
csharp
Copiar código
public class Estacionamento
{
    private List<string> C_Placas = new List<string>();

    public void CadastrarVeiculo(string placa) 
    {
        C_Placas.Add(placa);
        Console.WriteLine($"A placa {placa} foi cadastrada com sucesso!!");
    }

    public void RemoverVeiculo(string placa)
    {
        if (C_Placas.Remove(placa))
        {
            Console.WriteLine($"A placa {placa} foi removida com sucesso!!");
        }
        else
        {
            Console.WriteLine($"A placa {placa} não foi encontrada.");
        }
    }

    public void ListarVeiculos()
    {
        if (C_Placas.Count == 0)
        {
            Console.WriteLine("Nenhum veículo cadastrado.");
        }
        else
        {
            foreach (var placa in C_Placas)
            {
                Console.WriteLine(placa);
            }
        }
    }
}
Menu Principal
csharp
Copiar código
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
    
    // Switch case para escolher a opção
}
Como Usar
Compile o projeto.
Execute o aplicativo.
Siga as instruções no console para cadastrar, remover ou listar veículos.
Insira os valores iniciais e por hora quando solicitado.
Utilize as opções do menu para interagir com o sistema.
Requisitos
.NET 5.0 ou superior.
Ambiente de desenvolvimento (IDE) como Visual Studio ou VS Code.
Contribuições
Sinta-se à vontade para contribuir com melhorias ou novas funcionalidades. Crie um fork deste repositório, faça suas alterações e envie um pull request!

Licença
Este projeto é de código aberto e está licenciado sob a Licença MIT.
