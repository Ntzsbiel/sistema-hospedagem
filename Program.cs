using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
    Reserva reserva = new Reserva();
    Suite suite = new Suite("Luxo", 4, 150.0m); // Exemplo de suíte
    reserva.CadastrarSuite(suite);

    while (true)
    {
        Console.WriteLine("\nMenu de Reservas:");
        Console.WriteLine("1. Cadastrar Hóspedes");
        Console.WriteLine("2. Escolher Suíte");
        Console.WriteLine("3. Informar Dias de Estadia");
        Console.WriteLine("4. Exibir Detalhes da Reserva");
        Console.WriteLine("5. Sair");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.Write("Quantos hóspedes deseja cadastrar? ");
                int qtdHospedes = int.Parse(Console.ReadLine());
                List<Pessoa> hospedes = new List<Pessoa>();
                for (int i = 0; i < qtdHospedes; i++)
                {
                    Console.Write($"Digite o nome do hóspede {i + 1}: ");
                    string nome = Console.ReadLine();
                    hospedes.Add(new Pessoa(nome));
                }
                try
                {
                    reserva.CadastrarHospedes(hospedes);
                    Console.WriteLine("Hóspedes cadastrados com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
                break;

            case "2":
                Console.WriteLine($"Suíte selecionada: {suite.TipoSuite} (Capacidade: {suite.Capacidade}, Valor: {suite.ValorDiaria:C})");
                break;

            case "3":
                Console.Write("Quantos dias deseja reservar? ");
                reserva.DiasReservados = int.Parse(Console.ReadLine());
                Console.WriteLine("Dias de estadia registrados!");
                break;

            case "4":
                Console.WriteLine(reserva.ObterQuantidadeHospedes());
                Console.WriteLine(reserva.CalcularValorDiaria());
                break;

            case "5":
                Console.WriteLine("Encerrando o programa...");
                return;

            default:
                Console.WriteLine("Opção inválida! Tente novamente.");
                break;
        }
    }

