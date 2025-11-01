Console.Clear();
//Implemente uma calculadora com as quatro operações aritméticas básicas 
//(soma, subtração, multiplicação e divisão).
//O programa deverá conter um menu de opções selecionáveis pelo usuário, 
//incluindo as quatro operações e uma opção para o usuário sair do programa.

string menu = @"Selecione uma opção:
1 - Soma
2 - Subtração
3 - Multiplicação
4 - Divisão
X - Sair";

string opcao = "";

while(opcao != "X")
{
    Console.WriteLine(menu);
    opcao = Console.ReadLine()!;

    double n1, n2;
    if (opcao == "1")
    {
        Console.WriteLine(" -- Soma --");
        Console.Write("Informe o primeiro numero: ");
        n1 = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("Informe o segundo numero: ");
        n2 = Convert.ToDouble(Console.ReadLine()!);

        Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
    }
    else if (opcao == "2")
    {
        Console.WriteLine(" -- Subtração --");
        Console.Write("Informe o primeiro numero: ");
        n1 = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("Informe o segundo numero: ");
        n2 = Convert.ToDouble(Console.ReadLine()!);

        Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
    }
    else if (opcao == "3")
    {
        Console.WriteLine(" -- Multiplicação --");
        Console.Write("Informe o primeiro numero: ");
        n1 = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("Informe o segundo numero: ");
        n2 = Convert.ToDouble(Console.ReadLine()!);

        Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
    }
    else if (opcao == "4")
    {
        Console.WriteLine(" -- Divisão --");
        Console.Write("Informe o primeiro numero: ");
        n1 = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("Informe o segundo numero: ");
        n2 = Convert.ToDouble(Console.ReadLine()!);

        if (n2 == 0)
        {
            Console.WriteLine("Divisão por zero.");
        }
        else
        {
            Console.WriteLine($"{n1} / {n2} = {n1 / n2}");    
        }        
    }
}