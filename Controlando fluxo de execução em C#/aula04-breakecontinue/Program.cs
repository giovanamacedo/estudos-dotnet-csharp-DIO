Boolean condicao = true;
int valor;

do
{
  Console.WriteLine("Digite um valor ou digite 0 para SAIR.");

  valor = int.Parse(Console.ReadLine());
  if (valor == 0)
  {
    Console.WriteLine("Você saiu da aplicação.");
    break;
  }
  else
  {
    Console.WriteLine("O valor informado é: " + valor);
    continue;
  }
} while (condicao == true);