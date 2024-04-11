// 1 - Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
// Encontre o maior dentre 3 números:
// Primeiro Número : 65465
// Segundo Número : 64658
// Terceiro Número : 65464
// O primeiro número : 65465 é o maior

// Console.WriteLine("Digite o seu primeiro número");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Digite o seu segundo número");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Digite o seu terceiro número");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2 && num1 > num3)
// {
//     Console.WriteLine($"O primeiro número é o maior: {num1}");
// }
// else
// {
//     if(num2 > num3 && num2 > num1)
//     {
//         Console.WriteLine($"O segundo número é o maior: {num2}");
//     }
//     else
//     {
//         Console.WriteLine($"O terceiro número é o maior: {num3}");
//     }
// }

// 2- Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop 
// while, do-while e for.
// Os 10 primeiros números naturais são :
// 1 2 3 4 5 6 7 8 9 10
// A soma dos números é : 55

// Console.WriteLine("Os 10 primeiros números naturais são : 1 2 3 4 5 6 7 8 9 10");

// int contadorWhile = 1, somaWhile = 0;
// while(contadorWhile <= 10)
// {
//     somaWhile+=contadorWhile;
//     contadorWhile++;
//     Console.WriteLine($"A soma usando While é: {somaWhile}");
// }

// int contadorDo = 1, somaDo = 0;
// do
// {
//     somaDo+=contadorDo;
//     contadorDo++;
//     Console.WriteLine($"A soma usando Do é: {somaDo}");
// } while(contadorDo <= 10);

// int somaFor = 0;
// for(int i = 1; i <= 10; i++)
// {
//     somaFor+=i;
//     Console.WriteLine($"A soma usando For é: {somaFor}");
// }


// 3- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero 
// recebido via teclado 
// - Verifique se o número é maior que zero e emita uma mensagem
// - Considere a tabela de multiplicação de 1 até 10
// - Após exibir a tabela torne a solicitar outro número 
// - Para sair do loop defina uma condição de saída 
// Dica: Use os loop while e for e para sair a instrução break;


// while(true)
// {
//     Console.WriteLine("Digite um número natural maior que zero:");
//     int numeroUser = Convert.ToInt32(Console.ReadLine());

//     //Verifica se não digitou número negativo ou zero
//     if(numeroUser <= 0)
//     {
//         Console.WriteLine("Você digitou um número maior que zero! Tente Novamente!");
//         continue;
//     }
//     else
//     {
//         //Multiplicação de 1 até 10
//         for(int i = 1; i <= 10; i++)
//         {
//             int resultado = i*numeroUser;
//             Console.WriteLine($"{i} X {numeroUser} = {resultado}");
//         }
//     }
// }

// 4- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 
// maneiras diferentes:
// - Incrementando 2 em cada passo
// - Incrementando 1 em cada passo 
// - Com e loop infinito (use "break" e "continue")

// for(int i = 10; ; i+=2)
// {
//     if(i = 1)
//     continue;
//     if(i > 20)
//     break;

//     Console.WriteLine($"i = {i}");
// }

// 5 - Escreva um programa para calcular o fatorial de um número inteiro. 
// O fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1 
// Exemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1

// int i, f = 1, num;

// Console.WriteLine("Digite um número maior que zero");
// num = Convert.ToInt32(Console.ReadLine());

// for(i = 1; i <= num; i++)
// {
//     f*=i;
// }
// Console.WriteLine($"O fatorial de {num} é: {f}");

// 6 - Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado

// int numero = 2;

// do{
//     int multiplicador = 1;
//     do{
//         Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");
//         multiplicador++;
//     }while(multiplicador <= 10);
//     numero++;
// }while(numero <= 6);
 

// 7 - Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de 
// um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a 
// instrução switch, break e default em um loop infinito e defina uma condição de saida.)

// while(true)
// {
//     Console.WriteLine("Informe a nota do aluno:");
//     int x = Convert.ToInt32(Console.ReadLine());
//     if(x == 99)
//     break;

//     switch(x)
//     {
//     case 10:
//     Console.WriteLine("A+");
//     break;
//     case 9:
//     Console.WriteLine("A");
//     break;
//     case 8:
//     case 7:
//     Console.WriteLine("B");
//     break;
//     case 6:
//     Console.WriteLine("C");
//     break;
//     case 5:
//     Console.WriteLine("E");
//     break;
//     default:
//     Console.WriteLine("F");
//     break;
//     }
// } 

// 8 - Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números 
// inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e 
// quando isso ocorrer exibir uma mensagem de alerta

int num1;
int num2;
string operacao;
float respota;

Console.WriteLine("Informe o primero número:");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número:");
num1 = int.Parse(Console.ReadLine());