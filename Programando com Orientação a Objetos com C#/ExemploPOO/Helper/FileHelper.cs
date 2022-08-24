namespace ExemploPOO.Helper
{
  public class FileHelper
  {
    public void ListarDiretorios(string caminho)
    {
      var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

      foreach (var retorno in retornoCaminho)
      {
        System.Console.WriteLine("CAMINHO: " + retorno);
      }
    }

    public void ListarArquivosDiretorios(string arquivos)
    {
      var retornoArquivos = Directory.GetFiles(arquivos, "*.txt", SearchOption.AllDirectories);
      foreach (var retorno in retornoArquivos)
      {
        System.Console.WriteLine("ARQUIVO: " + retorno);
      }
    }

    public void CriarDiretorio(string caminho)
    {
      var retornoCriarArquivos = Directory.CreateDirectory(caminho);
      System.Console.WriteLine("CRIANDO DIRETÓRIO: " + retornoCriarArquivos.FullName);
    }

    public void ApagarDiretorio(string caminho, bool apagarArquivos)
    {
      Directory.Delete(caminho, apagarArquivos);
    }

    public void CriarArquivoTexto(string caminho, string conteudo)
    {
      if (File.Exists(caminho))
      {
        File.WriteAllText(caminho, conteudo);
      }
    }

    public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
    {
      using (var stream = File.CreateText(caminho))
      {
        foreach (var linha in conteudo)
        {
          stream.WriteLine(linha);
        }
      }
    }

    //Adiciona texto ao arquivo sem substituir ele, se o arquivo não existir ele é criado
    public void AdicionarTexto(string caminho, string conteudo)
    {
      File.AppendAllText(caminho, conteudo);
    }

    public void AdicionarTextoStream(string caminho, List<string> conteudo)
    {
      using (var stream = File.AppendText(caminho))
      {
        foreach (var linha in conteudo)
        {
          stream.WriteLine(linha);
        }
      }
    }

    public void LerArquivo(string caminho)
    {
      var conteudo = File.ReadAllLines(caminho);

      foreach (var linha in conteudo)
      {
        System.Console.WriteLine(linha);
      }
    }

    public void LerArquivoStream(string caminho)
    {
      string linha = string.Empty;

      using (var stream = File.OpenText(caminho))
      {
        while ((linha = stream.ReadLine()) != null)
        {
          System.Console.WriteLine("LER ARQUIVO: " + linha);
        }
      }
    }

    public void MoverArquivo(string caminho, string caminhoNovo)
    {
      File.Move(caminho, caminhoNovo);
    }

    public void CopiarArquivo(string caminho, string caminhoNovo, bool sobrescrever)
    {
      File.Copy(caminho, caminhoNovo, sobrescrever);
    }

    public void DeletarArquivo(string caminho)
    {
      File.Delete(caminho);
    }
  }
}