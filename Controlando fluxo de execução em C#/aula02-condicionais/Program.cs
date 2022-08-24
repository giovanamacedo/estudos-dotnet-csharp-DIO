// See https://aka.ms/new-console-template for more information
/* int idade;

Console.WriteLine("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
  Console.WriteLine("Você é maior de idade.");
}
else
{
  Console.WriteLine("Você é menor de idade.");
} */

int mes;
Console.WriteLine("Digite um número do mês: ");
mes = int.Parse(Console.ReadLine());

/*
if (mes == 1)
{
  Console.WriteLine("Janeiro");
}
else if (mes == 2)
{
  Console.WriteLine("Fevereiro");
}
else
{
  Console.WriteLine("Mês inválido");
} 
*/

switch (mes)
{
  case 1:
    Console.WriteLine("Janeiro");
    break;
  case 2:
    Console.WriteLine("Fevereiro");
    break;
  default:
    Console.WriteLine("Mês inválido");
    break;
}