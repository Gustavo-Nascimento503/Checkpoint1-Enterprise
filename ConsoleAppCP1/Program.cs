// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;

using ClassLibraryCP1.Model;
var controlarExecucao = true;
var contasCadastradas = new List<Conta>();

while (controlarExecucao)
{
    Console.WriteLine("\nEscolha uma opção: ");
    Console.WriteLine(
        "\n1- Cadastrar conta" +
        "\n2- Listar Contas " +
        "\n3- Depositar" +
        "\n4- Sacar" +
        "\n5- Calcular imposto" +
        "\n6- Sair");
    Console.Write("Opção desejada: ");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            Console.Write("Qual tipo de conta deseja criar? " +
                "\nDigite 1 para Conta Corrente " +
                "\nDigite 2 para Conta Poupanca" +
                "\nDigite 3 para Conta Salario" +
                "\nDigite 4 para Conta Conjunta\n");
            Console.Write("Opção desejada: ");
            var conta = Console.ReadLine();
            

            if (conta == "1")
            {
                var contaCorrente = new ContaCorrente();

                Console.WriteLine("\n### Cadastrando Conta Corrente ###");

                Console.Write("Digite o nome do Titular: ");
                contaCorrente.SetTitular(Console.ReadLine());

                Console.Write("Digite o Número da Conta: ");
                contaCorrente.SetNumero(Console.ReadLine());

                Console.Write("Digite a sua agência: ");
                contaCorrente.SetAgencia(Console.ReadLine());

                Console.Write("Digite o chque especial ");
                contaCorrente.SetCheckEspecial(double.Parse(Console.ReadLine()));

                contasCadastradas.Add(contaCorrente);
            }
            else if (conta == "2")
            {
                var contaPoupanca = new ContaPoupanca();

                Console.WriteLine("\n### Cadastrando Conta Poupança ###");

                Console.Write("Digite o nome do Titular: ");
                contaPoupanca.SetTitular(Console.ReadLine());

                Console.Write("Digite o Número da Conta: ");
                contaPoupanca.SetNumero(Console.ReadLine());

                Console.Write("Digite a sua agência: ");
                contaPoupanca.SetAgencia(Console.ReadLine());
                contaPoupanca.SetRentabilidade(0);

        
                contasCadastradas.Add(contaPoupanca);

            }

            else if (conta == "3")
            {
                var contaSalario = new ContaSalario();

                Console.WriteLine("\n### Cadastrando Conta Salario ###");


                Console.Write("Digite o nome do Titular: ");
                contaSalario.SetTitular(Console.ReadLine());

                Console.Write("Digite o Número da Conta: ");
                contaSalario.SetNumero(Console.ReadLine());

                Console.Write("Digite a sua agência: ");
                contaSalario.SetAgencia(Console.ReadLine());

                Console.Write("Digite a empresa pagante: ");
                contaSalario.SetEmpresaPagante(Console.ReadLine());


                contasCadastradas.Add(contaSalario);

            }

            else if (conta == "4")
            {
                var contaConjunta = new ContaConjunta();

                Console.WriteLine("\n### Cadastrando Conta Conjunta ###");

                Console.Write("Digite o nome do Titular: ");
                contaConjunta.SetTitular(Console.ReadLine());

                Console.Write("Digite o nome do secundario: ");
                contaConjunta.SetTitularSecundario(Console.ReadLine());

                Console.Write("Digite o Número da Conta: ");
                contaConjunta.SetNumero(Console.ReadLine());

                Console.Write("Digite a sua agência: ");
                contaConjunta.SetAgencia(Console.ReadLine());


                contasCadastradas.Add(contaConjunta);

            }

            break;
        case "2":

            Console.WriteLine("\n### Exibindo contas ###");

            foreach (var Varreconta in contasCadastradas)
            {
                Varreconta.ExibirConta();
            }


            break;
        case "3":
            Console.WriteLine("\n### Depositando na Conta Salario ###");

            Console.Write("Digite o número da conta para depositar: ");
            var numeroConta = Console.ReadLine();

            Conta contaEncontrada = null;
            foreach (var Busca in contasCadastradas)
            {
                if (Busca.GetNumero() == numeroConta)
                {
                    contaEncontrada = Busca;
                    break;
                }
            }

            if (contaEncontrada != null)
            {
                Console.Write("Digite o valor a ser depositado: ");
                var valorDeposito = double.Parse(Console.ReadLine());

                contaEncontrada.Depositar(valorDeposito);

                Console.WriteLine($"Depósito realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Conta não encontrada.");
            }
            break;

            
        case "4":
            Console.WriteLine("\n### Sacando da conta ###");

            Console.Write("Digite o número da conta para sacar: ");
            numeroConta = Console.ReadLine();

            contaEncontrada = null;
            foreach (var acc in contasCadastradas)
            {
                if (acc.GetNumero() == numeroConta)
                {
                    contaEncontrada = acc;
                    break;
                }
            }

            if (contaEncontrada != null)
            {
                Console.Write("Digite o valor a ser sacado: ");
                var valorSaque = double.Parse(Console.ReadLine());

                if (valorSaque > 0)
                {
                    if (contaEncontrada.GetSaldo() >= valorSaque)
                    {
                        contaEncontrada.juros(0.1);
                        contaEncontrada.Sacar(valorSaque);
                        Console.WriteLine($"Saque realizado com sucesso na conta .");
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente.");
                    }
                }
                else
                {
                    Console.WriteLine("O valor do saque deve ser maior que zero.");
                }
            }
            else
            {
                Console.WriteLine("Conta não encontrada.");
            }
            break;
        case "5":
            Console.WriteLine("\n### Calculando imposto ###");

            Console.Write("Digite o número da conta para calcular o imposto: ");
            numeroConta = Console.ReadLine();

            contaEncontrada = null;
            foreach (var acc in contasCadastradas)
            {
                if (acc.GetNumero() == numeroConta)
                {
                    contaEncontrada = acc;
                    break;
                }
            }

            if (contaEncontrada != null)
            {
                double taxaImposto = 0.1;
                contaEncontrada.AplicarImposto(taxaImposto);
                Console.WriteLine($"Imposto sobre o saldo da conta {numeroConta}: {taxaImposto}");
            }
            else
            {
                Console.WriteLine("Conta não encontrada.");
            }


            break;
        default:
            controlarExecucao = false;
            break;
    }
}
