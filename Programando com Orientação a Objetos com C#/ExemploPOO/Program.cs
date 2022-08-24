using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

//EXERCICIO CRIAÇÃO DE OBJETO PESSOA
/* Pessoa p1 = new Pessoa();
p1.Nome = "Giovana";
p1.Idade = 19;
p1.Apresentar(); */

//EXERCICIOS SOBRE OS PILARES DA ORIENTAÇÃO A OBJETOS
/* Retangulo r = new Retangulo();

r.DefinirMedidas(30, 30);
System.Console.WriteLine($"Área: {r.ObterArea()}"); */

/* Aluno a1 = new Aluno();
a1.Nome = "Bob";
a1.Idade = 17;
a1.Documento = "123456";
a1.Nota = 10;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Solange";
p1.Idade = 53;
p1.Documento = "123456";
p1.Salario = 5000;
p1.Apresentar(); */

/* Calculadora c1 = new Calculadora();
System.Console.WriteLine("Resultado da primeira soma: " + c1.Somar(10, 10));
System.Console.WriteLine("Resultado da segunda soma: " + c1.Somar(10, 10, 10)); */

//EXERCICIO CLASSE ABSTRATA
/* Corrente c = new Corrente();
c.Creditar(100);
c.ExibirSaldo(); */

//EXERCICIO DE APRESENTAÇÃO DA CLASSE OBJECT
/* Computador computador = new Computador();
System.Console.WriteLine(computador.ToString()); */

//EXERCIO INTERFACE
/* ICalculadora calculadora = new Calculadora();
System.Console.WriteLine("Seu resultado é: " + calculadora.Dividir(10, 2)); */

//EXERCICIOS MANIPULACAO ARQUIVOS
var caminho = "C:\\Users\\Giovana\\Desktop\\Eu\\Estudos\\DOTNET - DIO\\Programando com Orientação a Objetos com C#\\TrabalhandoComArquivos";

var caminhoPathCombine = Path.Combine(caminho, "PastaTeste1");
var caminhoNovoPathCombine = Path.Combine(caminho, "PastaTeste2", "arquivo-teste-stream.txt");

var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
var caminhoArquivoCopia = Path.Combine(caminho, "arquivo-copia-bkp.txt");

var listaStream = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
var adicionarConteudoStream = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

FileHelper helper = new FileHelper();
helper.ListarDiretorios(caminho);
System.Console.WriteLine(" ");

helper.ListarArquivosDiretorios(caminho);
System.Console.WriteLine(" ");

helper.CriarDiretorio(caminhoPathCombine);
System.Console.WriteLine(" ");

helper.ApagarDiretorio(caminhoPathCombine, true);
System.Console.WriteLine(" ");

//helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo .txt");
//helper.CriarArquivoTextoStream(caminhoArquivo, listaStream);
//helper.AdicionarTextoStream(caminhoArquivo, adicionarConteudoStream);

helper.LerArquivoStream(caminhoArquivo);
System.Console.WriteLine(" ");

//helper.MoverArquivo(caminhoArquivo, caminhoNovoPathCombine);

//helper.CopiarArquivo(caminhoArquivo, caminhoArquivoCopia, false);

helper.DeletarArquivo(caminhoArquivoCopia);