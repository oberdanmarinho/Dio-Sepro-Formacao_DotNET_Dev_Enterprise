using System.Diagnostics;
using Dio.Formação_DotNET_Dev_Enterprise.Models;
using Dio.Sepro_FormacaoDotNetDevEnterprise.Models;

// Pessoa (tipo da classe) | pessoa1(nome da variável que representa a classe) | new(instanciamento de classe) | Pessoa(Nome da classe instanciada)
//Pessoa pessoa1 = new Pessoa();

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


//DateTime dataAtual = DateTime.Now.AddDays(5);
//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0  && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


// if(quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");
// }
// else
// {
//     Console.WriteLine("Desculpe, nao temos a quantidade desejada em estoque");
// }



// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a" : 
//     case "e" : 
//     case "i" : 
//     case "o" : 
//     case "u" :
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Nâo é vogal");
//         break;
// }


// bool ehMaiorDeIdade = true;
// bool possuiAltorizacaoResponsavel = false;


// if (ehMaiorDeIdade || possuiAltorizacaoResponsavel)
// {
//     Console.WriteLine("Tudo bem, pode entrar.");
// }
// else
// {
//     Console.WriteLine("Entrda não liberada.");
// }

// Console.WriteLine("Informe sua idade");
// int idade = int.Parse(Console.ReadLine());

// if(idade >= 18)
// {
//     Console.WriteLine("Entrada permitida");
// }
// else{
//     Console.WriteLine("Entrada não permitida");
// }

// bool presencaMinima = true;
// double notaMedia =6;

// if(presencaMinima && notaMedia >= 7)
// {
//     Console.WriteLine("Parabens, você passou de ano");
// }
// else
// {
//     Console.WriteLine("Você não passou de ano");
// }


//Console.WriteLine("Informe sua nota: ");
//double nota = double.Parse(Console.ReadLine());

//Console.WriteLine("Informe sua media presente: ");
//int presenca = int.Parse(Console.ReadLine());

//if (nota >= 7 && presenca >= 10)
//{
//    Console.WriteLine("Voce está aprovado");
//}
//else
//{
//    Console.WriteLine("Você não está aprovado");
//}


//bool choveu = true;
//bool estaTarde = true;

//if (!choveu && !estaTarde)
//{
//    Console.WriteLine("Vou pedalar");
//}
//else
//{
//    Console.WriteLine("Vou pedalar outro dia");
//}

//Calculadora calc = new Calculadora();

//calc.Somar(10, 30);
//calc.Subtrair(10, 50);
//calc.Multiplicar(15, 45);
//calc.Dividir(2, 2);

//calc.Potencia(3, 3);

//calc.Seno(30);
//calc.Cosseno(30);
//calc.Tangenge(30);
//calc.raizQuadrada(9);

//int numeroIncremento = 10;

//int numeroDecremento = 20;

//Console.WriteLine(numeroIncremento);
//Console.WriteLine("Incrementando o 10");
////numero = numero + 1;
//numeroIncremento++;
//Console.WriteLine(numeroIncremento);

//Console.WriteLine(numeroDecremento);
//Console.WriteLine("Decremento do 20");
//numeroDecremento--;
//Console.WriteLine(numeroDecremento);

// int numero = 5;

// for(int contador = 0; contador <= 10 ; contador++ )
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }


// int numero = 5;
// int contador = 0;


// while (contador <= 10)
// {
//     Console.WriteLine($"{contador + 1}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if(contador == 6)
//     {
//         break;
//     }
// } 

// int numero, soma = 0;


// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;



// } while(numero != 0);


// Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");


// Construindo um menu

string opcao;
bool exibirMenu = true;


while(exibirMenu)
{
    Console.Clear();
    
    Console.WriteLine("Digite sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1" :
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            // Environment.Exit(0);
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("O programa se encerrou");