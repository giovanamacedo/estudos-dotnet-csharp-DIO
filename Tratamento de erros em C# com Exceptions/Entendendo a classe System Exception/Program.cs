using Entendendo_a_classe_System_Exception.Models;

int a = 100, b = 0;
double resultado = 0;

Dividir dividir = new Dividir();

try
{
  resultado = dividir.DividirNumeros(a, b);
  Console.WriteLine(a + " / " + b + " = ", resultado);
}
catch (DivideByZeroException e) /* when (a < 0) */
{
  Console.WriteLine(e.Message);
}
catch (Exception e)
{
  Console.WriteLine(e.Message);
}
finally
{
  Console.WriteLine("A divisão foi finalizada.");
}