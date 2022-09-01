using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
  public class Calculadora : ICalculadora
  {
    public int Multiplicar(int numero1, int numero2)
    {
      return numero1 * numero2;
    }

    public int Somar(int numero1, int numero2)
    {
      return numero1 + numero2;
    }

    public int Somar(int numero1, int numero2, int numero3)
    {
      return numero1 + numero2 + numero3;
    }

    public int Subtrair(int numero1, int numero2)
    {
      return numero1 - numero2;
    }
  }
}