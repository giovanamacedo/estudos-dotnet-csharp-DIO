/* Boolean condicao = true;*/
int valor;

/*
do
{
  Console.WriteLine("Digite um valor ou digite 0 para SAIR.");

  valor = int.Parse(Console.ReadLine());
  if (valor == 0)
  {
    Console.WriteLine("Você saiu da aplicação.");
    condicao = false;
  }
  else
  {
    Console.WriteLine("O valor informado é: " + valor);
  }
} while (condicao == true); */

/* Console.WriteLine("Digite um valor: ");
valor = int.Parse(Console.ReadLine());

for (int i = valor; i <= 10; i++)
{
  Console.WriteLine(i);
} */

int[] lista = { 1, 2, 3, 4, 5 };

foreach (int numero in lista)
{
  Console.WriteLine(numero);
}