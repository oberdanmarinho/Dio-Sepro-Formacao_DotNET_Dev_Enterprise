using Dio.Sepro_FormacaoDotNetDevEnterprise.Models;

// Pessoa (tipo da classe) | pessoa1(nome da variável que representa a classe) | new(instanciamento de classe) | Pessoa(Nome da classe instanciada)
Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Oberdan Marinho";
// pessoa1.Idade = 33;

// pessoa1.Apresentar();
// Valor monetário, sempre representar com o tipo Decimal

// string apresentacao = "Ola, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// bool cliente = true;
// decimal preco = 1.80M;

// Console.WriteLine("O valor da variavel apresentacao é : " + apresentacao);
// Console.WriteLine("O valor da variavel quantidade é : " + quantidade);
// Console.WriteLine("O valor da variavel altura é : " + altura.ToString("0.00"));
// Console.WriteLine("O valor da variavel cliente é : " + cliente);
// Console.WriteLine("O valor da variavel preco é : " + preco);


DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
