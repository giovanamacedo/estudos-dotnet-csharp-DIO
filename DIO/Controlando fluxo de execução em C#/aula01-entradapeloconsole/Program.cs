// See https://aka.ms/new-console-template for more information
int valor1;
int valor2;
int total;

Console.WriteLine("Digite o primeiro valor: ");
valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
valor2 = int.Parse(Console.ReadLine());

Console.WriteLine("Primeiro valor: " + valor1);
Console.WriteLine("Segundo valor: " + valor2);

total = valor1 + valor2;
Console.WriteLine("Soma dos valores: " + total);