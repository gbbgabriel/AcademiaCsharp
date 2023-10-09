
using System;
using System.Drawing;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

public static class Exercicio1
{
    static void Main()
    {
        //Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

        //Console.WriteLine("Escreva o primeiro número da soma: ");

        //int x = int.Parse(Console.ReadLine());

        //Console.WriteLine("Escreva o segundo número da soma: ");

        //int y = int.Parse(Console.ReadLine());

        //int media = (x + y) / 2;

        //Console.WriteLine($"A média do valor é: {media}");



        //-----------------------------------------------------------------------------------------------------------------------------



        //2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

        //Console.Write("Digite o primeiro número: ");
        //double num1 = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Digite o segundo número: ");
        //double num2 = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Digite o terceiro número: ");
        //double num3 = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Digite o quarto número: ");
        //double num4 = Convert.ToDouble(Console.ReadLine());

        //double media = (num1 + num2 + num3 + num4) / 4;

        //Console.WriteLine($"A média aritmética é: {media}");



        //-----------------------------------------------------------------------------------------------------------------------------


        //3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre si os valores de duas variáveis A e B.

        //int a = 5;
        //int b = 10;

        //Console.WriteLine($"Valores originais: A = {a}, B = {b}");

        //(a, b) = (b, a);

        //Console.WriteLine($"Valores trocados: A = {a}, B = {b}");



        //-----------------------------------------------------------------------------------------------------------------------------


        //4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

        //DateOnly data = DateOnly.Parse("10/03/2023");

        //Console.WriteLine($"{data.Year}/{data.Month:D2}/{data.Day:D2}");
        //Console.WriteLine($"{data.Year.ToString().Substring(2)}/{data.Month:D2}/{data.Day:D2}");



        //-----------------------------------------------------------------------------------------------------------------------------


        // 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel (medido em Km / l), sendo que são conhecidos a distância total percorrida e o volume de combustível consumido para percorrê-la(medido em l).

        //Console.Write("Digite a distância total percorrida (em Km): ");
        //double distancia = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Digite o volume de combustível consumido (em litros): ");
        //double volumeCombustivel = Convert.ToDouble(Console.ReadLine());

        //double consumoMedio = distancia / volumeCombustivel;

        //Console.WriteLine($"O consumo médio é: {consumoMedio} Km/l");



        //-----------------------------------------------------------------------------------------------------------------------------

        // 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem de IPI(única) a ser acrescentada.

        // ?




        //-----------------------------------------------------------------------------------------------------------------------------



        // 7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.


        //Console.Write("Digite o número do vendedor: ");
        //int numeroVendedor = int.Parse(Console.ReadLine());

        //Console.Write("Digite o salário fixo do vendedor: R$");
        //double salarioFixo = double.Parse(Console.ReadLine());

        //Console.Write("Digite o total de vendas em reais efetuadas pelo vendedor: R$");
        //double totalVendas = double.Parse(Console.ReadLine());

        //Console.Write("Digite o percentual de comissão sobre as vendas (em %): ");
        //double percentualComissao = double.Parse(Console.ReadLine());

        //double comissao = (percentualComissao / 100) * totalVendas;
        //double salarioTotal = salarioFixo + comissao;

        //Console.WriteLine($"\nResultados para o vendedor #{numeroVendedor}:");
        //Console.WriteLine($"Salário Fixo: R${salarioFixo:F2}");
        //Console.WriteLine($"Total de Vendas: R${totalVendas:F2}");
        //Console.WriteLine($"Percentual de Comissão: {percentualComissao}%");
        //Console.WriteLine($"Comissão: R${comissao:F2}");
        //Console.WriteLine($"Salário Total: R${salarioTotal:F2}");



        //-----------------------------------------------------------------------------------------------------------------------------



        // 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. A fórmula da conversão é F = (9 * C + 160) / 5.

        //Console.Write("Digite a temperatura em graus Celsius: ");
        //double temperaturaCelsius = double.Parse(Console.ReadLine());

        //double temperaturaFahrenheit = (9 * temperaturaCelsius + 160) / 5;

        //Console.WriteLine($"\nTemperatura em graus Fahrenheit: {temperaturaFahrenheit:F2} °F");



        //-----------------------------------------------------------------------------------------------------------------------------



        // 9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.
        // Por exemplo, se o valor da mercadoria for R$ 270, 00, a entrada e as duas prestações são iguais a R$ 90, 00; se o valor da mercadoria for R$ 302, 75 a entrada é de R$ 102, 75 e as duas prestações são iguais a R$ 100, 00.
        // Por exemplo, se o valor da mercadoria for R$ 270, 00, a entrada e as duas prestações são iguais a R$ 90, 00; se o valor da mercadoria for R$ 302, 75 a entrada é de R$ 102, 75 e as duas prestações são iguais a R$ 100, 00.
        // Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor da entrada e das duas prestações, de acordo com as regras acima. Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o conseqüente pagamento dos boletos das duas prestações.

        // Solicitar o valor e o número de parcelas ao usuário
        //int Prest1, Prest2;
        //float ValorM, ValorEnt;

        //Console.Write("Informe o Valor da Mercadoria: ");
        //ValorM = float.Parse(Console.ReadLine());

        //Prest1 = (int)(ValorM / 3);
        //Prest2 = Prest1;

        //ValorEnt = ValorM - (Prest1 + Prest2);

        //Console.WriteLine($"Valor de entrada: {ValorEnt:F2}\nValor da primeira prestação: {Prest1}\nValor da segunda prestação: {Prest2}");




        //-----------------------------------------------------------------------------------------------------------------------------


        // 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que
        // realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as notas de menor valor fossem distribuídas em número mínimo possível.
        // Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00, uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00.
        // Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas de acordo com o critério da “distribuição ótima”.

        //Console.WriteLine("Digite o valor do saque:");
        //int valor = int.Parse(Console.ReadLine());

        //int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
        //int[] quantidade = new int[7];

        //for (int i = 0; i < 7; i++)
        //{
        //    quantidade[i] = valor / notas[i];
        //    valor %= notas[i];
        //}

        //Console.WriteLine("Quantidade de notas:");
        //for (int i = 0; i < 7; i++)
        //{
        //    Console.WriteLine($"{notas[i]}: {quantidade[i]}");





        //-----------------------------------------------------------------------------------------------------------------------------


        // 11) Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.


        //Console.WriteLine("Digite o número de votos brancos:");
        //int brancos = int.Parse(Console.ReadLine());

        //Console.WriteLine("Digite o número de votos nulos:");
        //int nulos = int.Parse(Console.ReadLine());

        //Console.WriteLine("Digite o número de votos válidos:");
        //int validos = int.Parse(Console.ReadLine());

        //int totalVotos = brancos + nulos + validos;

        //double percBrancos = (double)brancos / totalVotos * 100;
        //double percNulos = (double)nulos / totalVotos * 100;
        //double percValidos = (double)validos / totalVotos * 100;

        //Console.WriteLine($"O total de eleitores do município é de: {totalVotos}");
        //Console.WriteLine($"Percentual de votos brancos: {percBrancos}%");
        //Console.WriteLine($"Percentual de votos nulos: {percNulos}%");
        //Console.WriteLine($"Percentual de votos válidos: {percValidos}%");




        //-----------------------------------------------------------------------------------------------------------------------------


        // 12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
        // marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total(R$) recebido dos passageiros.Calcule e escreva a média do consumo em Km / l e o lucro líquido do dia.
        // - Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia
        // - Média do consumo = Total quilometragem / quantidade de combustível gasto
        // - Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)


        //Console.WriteLine("Digite a marcação do odômetro no início do dia:");
        //int inicio = int.Parse(Console.ReadLine());

        //Console.WriteLine("Digite a marcação do odômetro no final do dia:");
        //int fim = int.Parse(Console.ReadLine());

        //Console.WriteLine("Digite o número de litros de combustível gasto:");
        //double litros = double.Parse(Console.ReadLine());

        //Console.WriteLine("Digite o valor total recebido dos passageiros:");
        //double valorTotal = double.Parse(Console.ReadLine());

        //double totalQuilometragem = fim - inicio;
        //double mediaConsumo = totalQuilometragem / litros;
        //double lucroLiquido = valorTotal - (litros * 6.90);

        //Console.WriteLine($"Média do consumo em Km/l: {mediaConsumo:F2}");
        //Console.WriteLine($"Lucro líquido do dia: R${lucroLiquido:F2}");




        //-----------------------------------------------------------------------------------------------------------------------------


        // 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o  preço de custo de cada bicicleta vendida.Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas
        // vendidas pelo vendedor, calcule e mostre: o salário do empregado


        //Console.WriteLine("Digite o valor do salário mínimo:");
        //double salarioMinimo = double.Parse(Console.ReadLine());

        //Console.WriteLine("Digite o preço de custo de cada bicicleta:");
        //double precoCusto = double.Parse(Console.ReadLine());

        //Console.WriteLine("Digite o número de bicicletas vendidas pelo vendedor:");
        //int quantidade = int.Parse(Console.ReadLine());

        //double precoVenda = precoCusto * 1.5;
        //double comissao = precoCusto * 0.15 * quantidade;
        //double salarioVendedor = salarioMinimo * 2 + comissao;

        //Console.WriteLine($"O salário do vendedor é: R${salarioVendedor:F2}");
    }
}





