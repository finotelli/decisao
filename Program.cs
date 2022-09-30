int n1, n2;

Console.WriteLine("Divisão de dois numeros");

Console.WriteLine("Digite o primeiro numero:");
n1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Digite o segundo numero:");
n2 = Convert.ToInt32 (Console.ReadLine());

bool valorInvalido = n2 == 2;
if (valorInvalido)


{

    double resultado = n1 / n2;
    Console.WriteLine($"{n1} dividido por {n2} é {resultado}");

}