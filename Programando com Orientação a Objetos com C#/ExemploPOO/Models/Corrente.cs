namespace ExemploPOO.Models
{
  public class Corrente : Conta
  {
    public override void Creditar(double valor)
    {
      base.saldo = valor; //base quer dizer que o atributo pertence a classe pai, a classe herdada
    }

  }
}