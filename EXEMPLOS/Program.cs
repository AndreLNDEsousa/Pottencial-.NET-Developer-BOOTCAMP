using EXEMPLOS.Models;


//Cast - casting, conversão de string
//Diferença entre convert e parse, convert aceita nullo e apresenta "0". O parse dá erro
int a = Convert.ToInt32(null);
// int a = int.Parse("null");

Console.WriteLine(a);
//Operadores (+ - * /)
// int a = 10;
// int b = 20;

// int c = a+b;
// // c = c+5; a operação abaixo é a mesma coisa
// c +=5;
// Console.WriteLine(c);



//tipos de data e hora 
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual);


//Tipos de dados
// string apresentacao = "Olá seja bem vindo!";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80m;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade : " + quantidade);
// Console.WriteLine("Valor da variável altura : " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço : " + preco);
// Console.WriteLine("Valor da variável condição : " + condicao);

// Pessoa pessoa1 = new Pessoa();

// Console.WriteLine("Aprendendo C# com a DIO!");

// Console.WriteLine("\n");

// Console.WriteLine("Pessoa Comum...");
// pessoa1.Nome = "ANDRE";
// pessoa1.Idade = 37 ;
// pessoa1.Apresentar();

// Console.WriteLine("\n");

// Pessoa PessoaFisicaRepresentacao = new Pessoa();

// Console.WriteLine("Pessoa Física...");
// PessoaFisicaRepresentacao.Nome = "ANDRE SOUSA";
// PessoaFisicaRepresentacao.Idade = 37;
// PessoaFisicaRepresentacao.Apresentar();