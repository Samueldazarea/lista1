/*Questão 4: Somatório de Moedas
• Contextualização: No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total
de moedas aumenta.
• Comando: Desenvolva um programa que receba cinco valores de moedas coletadas e some-os,
exibindo o total de moedas coletadas ao final.

@Lista: 01 - Lógica de Programação
@Autor: Samuel Barbosa Chaves Brandão
@Data: 19/08/2024*/

using System;
class Program
{
    static void Main(string[] args)
    {

        double M1, M2, M3, M4, M5, final;

        System.Console.WriteLine("O VALOR DA PRIMEIRA MOEDA");
        double.TryParse(Console.ReadLine(), out M1);

        System.Console.WriteLine("O VALOR DA SEGUNDA MOEDA");
        double.TryParse(Console.ReadLine(), out M2);

        System.Console.WriteLine("O VALOR DA TERCEIRA MOEDA");
        double.TryParse(Console.ReadLine(), out M3);

        System.Console.WriteLine("O VALOR DA QUARTA MOEDA");
        double.TryParse(Console.ReadLine(), out M4);

        System.Console.WriteLine("O VALOR DA QUINTA MOEDA");
        double.TryParse(Console.ReadLine(), out M5);

        final = (M1+ M2 + M3 + M4 + M5);
        System.Console.WriteLine("PONTUAÇÃO FINAL: "+ final);
        Console.ReadLine();
    
    }
}