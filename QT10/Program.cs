/*Questão 10: Atualização de Pontos de Vida
• Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida a
cada nível alcançado.
• Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento de vida
por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível.

@Lista: 01 - Lógica de Programação
@Autor: Samuel Barbosa Chaves Brandão
@Data: 19/08/2024*/

using System;
using System.ComponentModel.DataAnnotations.Schema;
class Program
{
    static void Main(string[] args)
    {
        double pvi, aumN, nivA, pvf;

        System.Console.WriteLine("QUAIS OS SEUS PONTOS DE VIDA INICIAL");
        double.TryParse(Console.ReadLine(), out pvi);

        System.Console.WriteLine("QUANTIDADE DE AUMENTO POR NIVEL");
        double.TryParse(Console.ReadLine(), out aumN);
    
        System.Console.WriteLine("QUAL FOI O NIVEL ALCANÇADO");
        double.TryParse(Console.ReadLine(), out nivA);

        pvf = pvi + aumN * nivA;
        System.Console.WriteLine("PONTUAÇÃO FINAL: " + pvf);
        Console.ReadLine();       
    }
}