using Entendendo_a_classe_System_Exception.Models;

int a = 100, b = 0;
double resultado = 0;

Dividir dividir = new Dividir();

try
{
  resultado = dividir.DividirNumeros(a, b);
  Console.WriteLine(a + " / " + b + " = ", resultado);
}
catch (Exception e)
{
  Console.WriteLine(e.Message);
}
