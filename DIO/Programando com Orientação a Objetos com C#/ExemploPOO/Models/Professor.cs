namespace ExemploPOO.Models
{
  public class Professor : Pessoa
  {
    public double Salario { get; set; }

    public sealed override void Apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos. Meu salário é R${Salario}.");
    }
  }
}