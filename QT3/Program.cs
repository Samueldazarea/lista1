/*Questão 3: Cálculo de Vida Restante
• Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem
diminui.
• Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
para habilidades), e calcule a vida restante.

@Lista: 01 - Lógica de Programação
@Autor: Samuel Barbosa Chaves Brandão
@Data: 19/08/2024*/

using System;
using System.Runtime.ConstrainedExecution;
class Program
{
    static void Main(string[] args)
{
    double VI, DR, BR, ME, MH, final;

    System.Console.WriteLine("VALOR DA VIDA INICIAL");
    double.TryParse(Console.ReadLine(), out VI);

    System.Console.WriteLine("VALOR DO DANO RECEBIDO");
    double.TryParse(Console.ReadLine(), out DR);

    System.Console.WriteLine("VALOR DO BÔNUS DE RECUPERAÇÃO");
    double.TryParse(Console.ReadLine(), out BR);

    System.Console.WriteLine("VALOR DO MODIFICADOR DE EQUIPAMENTOS");
    double.TryParse(Console.ReadLine(), out ME);

    System.Console.WriteLine("VALOR DO MODIFICADOR DE HABILIDADES");
    double.TryParse(Console.ReadLine(), out MH);

    final = (((VI-DR+BR)*DR*ME)*VI*MH);
    System.Console.WriteLine("PONTUAÇÃO FINAL:"+final);
    Console.ReadLine();
    
}

}