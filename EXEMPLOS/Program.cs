using EXEMPLOS.Models;


//EXEMPLO DE MENU INTERATIVO

string opcao;
bool exibirmenu = true;

while (exibirmenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
        Console.WriteLine("Cadastro de cliente");
        break;

        case "2":
        Console.WriteLine("Busca de cliente");
        break;

        case "3":
        Console.WriteLine("Apagar cliente");
        break;

        case "4":
        Console.WriteLine("Sua aplicação finalizou!!!");
        // Environment.Exit(0);
        exibirmenu = false;
        break;

        default:
        Console.WriteLine("Opção inválida!!");
        break;

    }

}

Console.WriteLine("O programa se encerou");













//LAÇOS DE REPETIÇÃO

// DO WHILE

// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número: (0 para parar)");
//      numero = Convert.ToInt32(Console.ReadLine());

//      soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");






//WHILE
// int numero = 5;
// int contador = 0;
// int auxiliar = 0;

// while (contador <=10)
// {
//     Console.WriteLine($"{contador}º Execução {numero} x {contador} = {numero *contador}");
//     contador++;
// }





//FOR
// int numero = 5;

// for (int contador = 1; contador<= 10; contador++)
// {
//   Console.WriteLine($"{numero} x {contador} = {numero *contador}");
// }



//******************************************************
//OPERADORES ARITMÉTICOS EM C#.

// Calculadora calc = new Calculadora ();
// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia (3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);


//*******************************************************
//INCREMENTO E DECREMENTO
// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine($"Incremento de 10 = {numero++} ");
// //10+1

// Console.WriteLine($"Decrementando de 10 = {numero--} ");
// //10-1



//*********************************************************
//OPERADOR NOT (!)
// bool choveu = false;
// bool estaTarde = true;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar!!!");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia!!!");
// }



//*********************************************************
//OPERADOR AND (&&)
// bool possuiPresencaMinima = true;
// double media = 6.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!!!");
// }
// else
// {
//       Console.WriteLine("Reprovado!!!");
// }





//**********************************************************
//OPERADOR OR

// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoRepresentante = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoRepresentante)
// {
//     Console.WriteLine("Entrada Liberada.");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada!!!");
// }





//**********************************************
//Switch Case

// Console.WriteLine("Digite uma letra.");
// string letra = Console.ReadLine();

// USO DE SWITCH CASE
// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.WriteLine("Vogal");
//     break;

// default:
//     Console.WriteLine("Não é uma vogal");
//     break;

// }

//Segunda Forma
// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u" ||
// )
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal!!!");
// }


//Proimeira forma
// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal!!!");
// }

//***********************************
// //IF aninhado
// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine ($"Quantidade em estoque :{quantidadeEmEstoque}");
// Console.WriteLine ($"Quantidade Compra  :{quantidadeCompra}");
// Console.WriteLine ($"È possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida!!");

// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");
// }
// else 
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }


//*******************************************

// //Cast - casting, conversão de string
// //Diferença entre convert e parse, convert aceita nullo e apresenta "0". O parse dá erro
// int a = Convert.ToInt32(null);
// // int a = int.Parse("null");

// Console.WriteLine(a);
//Operadores (+ - * /)
// int a = 10;
// int b = 20;

// int c = a+b;
// // c = c+5; a operação abaixo é a mesma coisa
// c +=5;
// Console.WriteLine(c);

//*************************************************

//tipos de data e hora 
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual);

//*************************************************************
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