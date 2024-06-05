using Controllers;
using Models;

do
{
    Console.Clear();
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Inserir Novo Serviço");
    Console.WriteLine("2. Relacionar Serviço e Carro");
    Console.WriteLine("0. Sair");

    Console.Write("\nDigite uma opção: ");
    int opc = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opc)
    {
        case 1:
            Console.WriteLine("--- Inserir Novo Serviço ---");
            Servico servico = new Servico();

            Console.Write("Insira a descrição do serviço: ");
            servico.Descricao = Console.ReadLine();

            Console.WriteLine(new ServicoController().InserirServico(servico) ? "\nRegistro Inserido - " + servico.Descricao : "Erro ao Inserir Registro");

            Console.Write("\nPressione qualquer tecla para continuar: ");
            Console.ReadLine();
            Console.Clear();

            break;

        case 2:
            Console.WriteLine("--- Associar Carro e Serviço ---\n");
            CarroServico carroServico = new CarroServico();

            Console.Write("Digite a Placa do Carro: ");
            carroServico.Carro.Placa = Console.ReadLine();

            Console.Write("\nDigite o Id do Serviço: ");
            carroServico.Servico.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira o status do serviço: ");
            Console.WriteLine("1. Ativo");
            Console.WriteLine("2. Concluido");
            Console.Write("\nDigite a opção: ");
            int status = int.Parse(Console.ReadLine());
            if (status == 1) carroServico.Status = true;
            if (status == 2) carroServico.Status = false;

            Console.WriteLine(new CarroServicoController().InserirRelacao(carroServico) ? "\nRegistro Inserido  " : "Erro ao Inserir Registro");
            break;

        case 0:
            Console.Clear();
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Opção Inválida!");
            Console.WriteLine();
            Console.Clear();
            break;



    }



} while (true);