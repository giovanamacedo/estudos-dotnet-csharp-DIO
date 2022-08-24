namespace ExemploPOO.Interfaces
{
  public interface ICalculadora
  {
    //Em interfaces não usamos modificadores de acesso  
    int Somar(int numero1, int numero2);
    int Subtrair(int numero1, int numero2);
    int Multiplicar(int numero1, int numero2);
    int Dividir(int numero1, int numero2)
    {
      return numero1 / numero2;
    }
  }
}