namespace Entendendo_a_classe_System_Exception.Models
{
  public class Dividir
  {
    public double DividirNumeros(int numero1, int numero2)
    {
      if (numero2 == 0)
      {
        throw new MyClassException("Minha mensagem customizada de erro.");
      }
      return (numero1 / numero2);
    }
  }
}