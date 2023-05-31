using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaaaaaaaaaaa77777
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO 1
            //int totalItens = 0;
            //decimal totalCompra = 0;

            //while (true)
            //{
            //    Console.Write("Quantidade de itens: ");
            //    int quantidade = int.Parse(Console.ReadLine());

            //    if (quantidade <= 0)
            //    {
            //        break;
            //    }

            //    Console.Write("Preço do produto: ");
            //    decimal preco = decimal.Parse(Console.ReadLine());

            //    totalItens += quantidade;
            //    totalCompra += quantidade * preco;
            //}

            //Console.WriteLine($"Total de itens: {totalItens}");
            //Console.WriteLine($"Valor total da compra: R${totalCompra}");
            //Console.ReadKey();


            ////EXERCICIO 2 
            //    string nomeProduto, continuar;
            //    int numeroItens;
            //    double precoCompra, investimentoProduto, investimentoMaximo = 0, investimentoMinimo = double.MaxValue;
            //    string produtoMaisInvestido = "", produtoMenosInvestido = "";


            //    while (true)
            //    {
            //        Console.Write("Digite o nome do produto (ou 'fim' para encerrar): ");
            //        nomeProduto = Console.ReadLine();

            //        if (nomeProduto.ToLower() == "fim") 
            //        {
            //            break;
            //        }

            //        Console.Write("Digite o número de itens do produto: ");
            //        numeroItens = int.Parse(Console.ReadLine());

            //        Console.Write("Digite o preço de compra do produto: ");
            //        precoCompra = double.Parse(Console.ReadLine());


            //        investimentoProduto = numeroItens * precoCompra;

            //        if (investimentoProduto > investimentoMaximo)
            //        {
            //            investimentoMaximo = investimentoProduto;
            //            produtoMaisInvestido = nomeProduto;
            //        }

            //        if (investimentoProduto < investimentoMinimo)
            //        {
            //            investimentoMinimo = investimentoProduto;
            //            produtoMenosInvestido = nomeProduto;
            //        }
            //    }

            //    Console.WriteLine("Produto com maior investimento: " + produtoMaisInvestido + " - Investimento total: " + investimentoMaximo.ToString("F2"));

            //    Console.WriteLine("Produto com menor investimento: " + produtoMenosInvestido + " - Investimento total: " + investimentoMinimo.ToString("F2"));
            //    Console.ReadKey();


            //EXERCICIO 3
            //int numAvaliacoes = 0;
            //double somaPesos = 0;

            //Console.Write("Informe o número de avaliações: ");
            //numAvaliacoes = int.Parse(Console.ReadLine());

            //int i = 1;
            //while (i <= numAvaliacoes)
            //{
            //    Console.Write("Informe o peso da avaliação " + i + ": ");
            //    double peso = double.Parse(Console.ReadLine());
            //    somaPesos += peso;
            //    i++;
            //}

            //if (somaPesos < 100)
            //{
            //    Console.WriteLine("A soma dos pesos é insuficiente. Total: " + somaPesos + "%");
            //}
            //else if (somaPesos > 100)
            //{
            //    Console.WriteLine("A soma dos pesos é excedente. Total: " + somaPesos + "%");
            //}
            //else
            //{
            //    Console.WriteLine("A soma dos pesos é adequada. Total: " + somaPesos + "%");


            ////4

            //string estado;

            //Console.WriteLine("qual a sigla do estado");

            //estado = Console.ReadLine();

            //switch (estado)

            //{

            //    case "AC":

            //        Console.WriteLine("o estado é: Acre");

            //        break;

            //    case "AL":

            //        Console.WriteLine("o estado é: Alagoas");

            //        break;

            //    case "AP":

            //        Console.WriteLine("o estado é: Amapá");

            //        break;

            //    case "AM":

            //        Console.WriteLine("o estado é: Amazonas");

            //        break;

            //    case "BA":

            //        Console.WriteLine("o estado é: Bahia");

            //        break;

            //    case "CE":

            //        Console.WriteLine("o estado é: Ceará");

            //        break;

            //    case "DF":

            //        Console.WriteLine("Distrito Federal não é um estado, mas sim uma uniudade autônoma");

            //        break;

            //    case "ES":

            //        Console.WriteLine("o estado é: Espírito Santo");

            //        break;

            //    case "GO":

            //        Console.WriteLine("o estado é: Goiás");

            //        break;

            //    case "MA":

            //        Console.WriteLine("o estado é: Maranhão");

            //        break;

            //    case "MT":

            //        Console.WriteLine("o estado é: Mato Grosso");

            //        break;

            //    case "MS":

            //        Console.WriteLine("o estado é: Mato Grosso do Sul");

            //        break;

            //    case "MG":

            //        Console.WriteLine("o estado é: Minas Gerais");

            //        break;

            //    case "PA":

            //        Console.WriteLine("o estado é: Pará");

            //        break;

            //    case "PB":

            //        Console.WriteLine("o estado é: Paraíba");

            //        break;

            //    case "PR":

            //        Console.WriteLine("o estado é: Paraná");

            //        break;

            //    case "PE":

            //        Console.WriteLine("o estado é: Pernambuco");

            //        break;

            //    case "PI":

            //        Console.WriteLine("o estado é: Piauí");

            //        break;

            //    case "RJ":

            //        Console.WriteLine("o estado é: Rio de Janeiro");

            //        break;

            //    case "RN":

            //        Console.WriteLine("o estado é: Rio Grande do Norte");

            //        break;

            //    case "RS":

            //        Console.WriteLine("o estado é: Rio Grande do Sul");

            //        break;

            //    case "RO":

            //        Console.WriteLine("o estado é: Rondônia");

            //        break;

            //    case "RR":

            //        Console.WriteLine("o estado é: Roraima");

            //        break;

            //    case "SC":

            //        Console.WriteLine("o estado é: Santa Catarina");

            //        break;

            //    case "SP":

            //        Console.WriteLine("o estado é: São Paulo");

            //        break;

            //    case "SE":

            //        Console.WriteLine("o estado é: Sergipe");

            //        break;

            //    case "TO":

            //        Console.WriteLine("o estado é: Tocantins");

            //        break;

            //    default:

            //        Console.WriteLine("nao existe estado com essa sigla");

            //        break;

            //}


            //5

            //int m, d;

            //Console.WriteLine("digite o mês");

            //m = int.Parse(Console.ReadLine());

            //switch (m)

            //{

            //    case 1:

            //        Console.WriteLine("a estação correspondente a este mês é: verão");

            //        break;

            //    case 2:

            //        Console.WriteLine("a estação correspondente a este mês é: verão");

            //        break;

            //    case 3:

            //        Console.WriteLine("qual é o dia?");

            //        d = int.Parse(Console.ReadLine());

            //        if (d < 20 && d > 1)

            //            Console.WriteLine("a estação correspondente a este mês é: verão");

            //        if (d >= 20 && d < 31)

            //            Console.WriteLine("a estação correspondente a este mês é: outono");

            //        break;

            //    case 4:

            //        Console.WriteLine("a estação correspondente a este mês é: verão");

            //        break;

            //    case 5:

            //        Console.WriteLine("a estação correspondente a este mês é: verão");

            //        break;

            //    case 6:

            //        Console.WriteLine("qual é o dia?");

            //        d = int.Parse(Console.ReadLine());

            //        if (d < 21 && d > 1)

            //            Console.WriteLine("a estação correspondente a este mês é: outono");

            //        if (d >= 21 && d < 30)

            //            Console.WriteLine("a estação correspondente a este mês é: inverno");

            //        break;

            //    case 7:

            //        Console.WriteLine("a estação correspondente a este mês é: inverno");

            //        break;

            //    case 8:

            //        Console.WriteLine("a estação correspondente a este mês é: inverno");

            //        break;

            //    case 9:

            //        Console.WriteLine("qual é o dia?");

            //        d = int.Parse(Console.ReadLine());

            //        if (d < 23 && d > 1)

            //            Console.WriteLine("a estação correspondente a este mês é: inverno");

            //        if (d >= 23 && d < 30)

            //            Console.WriteLine("a estação correspondente a este mês é: primavera");

            //        break;

            //    case 10:

            //        Console.WriteLine("a estação correspondente a este mês é: primavera");

            //        break;

            //    case 11:

            //        Console.WriteLine("a estação correspondente a este mês é: primavera");

            //        break;

            //    case 12:

            //        Console.WriteLine("qual é o dia?");

            //        d = int.Parse(Console.ReadLine());

            //        if (d < 22 && d > 1)

            //            Console.WriteLine("a estação correspondente a este mês é: primavera");

            //        if (d >= 22 && d < 30)

            //            Console.WriteLine("a estação correspondente a este mês é: verão");

            //        break;

            //    default:

            //        Console.WriteLine("o valor digitado é invalido");

            //        break;

            //6

            //double alt, kg, imc;

            //Console.WriteLine("Digite sua altura (em metros): ");

            //alt = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite seu peso (em kilos): ");

            //kg = double.Parse(Console.ReadLine());

            //imc = kg / (alt * alt);

            //if (imc < 18.5)

            //{

            //    Console.WriteLine("você está abaixo do peso");

            //    break;

            //}

            //if (imc >= 18.5 && imc <= 24.9)

            //{

            //    Console.WriteLine("você está no peso comum");

            //    break;

            //}

            //if (imc >= 25 && imc <= 29.9)

            //{

            //    Console.WriteLine("você está acima do peso");

            //    break;

            //}

            //if (imc >= 30 && imc < 34.9)

            //{

            //    Console.WriteLine("você está com obesidade grau 1");

            //    break;

            //}

            //if (imc >= 35 && imc < 39.9)

            //{

            //    Console.WriteLine("você está com obesidade grau 2");

            //    break;

            //}

            //if (imc >= 40)

            //{

            //    Console.WriteLine("você está com obesidade grau 3");

            //    break;

            //}


            ////7

            //int num;

            //Console.WriteLine("digite um numero");

            //num = int.Parse(Console.ReadLine());
            //int b = 1;
            //while (b < num)

            //{
            //    b++;
            //    if (num % b == 0)

            //        Console.WriteLine(i);

            //    else

            //        i++;

            //}

            //break;

            //default:

            //        Console.WriteLine("Número inválido");

            //break;

        }
    }
}
