using ExemploConstrutores.Models;

// Pessoa p1 = new Pessoa();
// Pessoa p2 = new Pessoa("Giovana", "Macedo");
// p2.Apresentar();

Log log = Log.GetInstance();
log.PropriedadeLog = "Teste instância";

Log log2 = Log.GetInstance();
System.Console.WriteLine(log2.PropriedadeLog);