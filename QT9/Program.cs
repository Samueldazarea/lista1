/*Questão 9: Comparação de Poder de Ataque
• Contextualização: Em um jogo de luta, cada personagem tem um valor de ataque baseado em
sua força, arma e bônus de habilidades.
• Comando: Crie um programa que receba o valor da força do personagem, o poder da arma, o
bônus de habilidades, e dois multiplicadores (um para tipo de inimigo e outro para ambiente), e
calcule o total de ataque.

@Lista: 01 - Lógica de Programação
@Autor: Samuel Barbosa Chaves Brandão
@Data: 19/08/2024*/

using System;
class Program
{
    static void Main(string[] args)
    {
        double fo,ar,bo,m1,m2,final;

        System.Console.WriteLine("QUANTOS PH TEM A FORÇA");
        double.TryParse(Console.ReadLine(), out fo);

        System.Console.WriteLine("QUANTOS PH TEM A ARMA");
        double.TryParse(Console.ReadLine(), out ar);

        System.Console.WriteLine("DIGA QUANTOS SÃO OS BONUS DE HABILIDADE");
        double.TryParse(Console.ReadLine(), out bo);

        System.Console.WriteLine("QUANTO FOI O MODIFICADOR CRITICO");
        double.TryParse(Console.ReadLine(), out m1);

        System.Console.WriteLine("QUANTO FOI O MODIFICADOR TIPO DE ARMA");
        double.TryParse(Console.ReadLine(), out m2);

        final = fo+(ar*bo*m1*m2);
        System.Console.WriteLine("PONTUAÇÃO FINAL: "+ final);
        Console.ReadLine();
    }
}