using CalculadoraFactoryApp.Factory;

Console.WriteLine("Executando a calculadora\n");
char? op;
do
{

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;

    try
    {
        Console.Write("Operações:\n\n soma\n subtracao\n divisao\n multiplicacao\n\n");
        Console.Write("Informa a operação desejada: ");
        var opcao = Console.ReadLine();

        Console.Write("Informe o primeiro valor: ");
        var valor1 = double.Parse(Console.ReadLine()!);

        Console.Write("Informe o segundo valor: ");
        var valor2 = double.Parse(Console.ReadLine()!);

        var operacao = FabricaDeOperacoes.GetOperacao(opcao!);
        Console.WriteLine($"Resultado da {opcao} : {operacao!.Calcular(valor1, valor2)}");
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Aconteceu uma exceção: {ex.Message}");
    }
    finally
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Deseja continuar? [s]im ou [n]ão.");
        Console.Write("Informe opção: ");
        op = Console.ReadLine()![0];
        Console.ForegroundColor = ConsoleColor.White;
    }    
   
} while (op.Equals('s'));