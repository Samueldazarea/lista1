/*Questão 7: Cálculo de Nível do Jogador
• Contextualização: Um jogador ganha uma certa quantidade de experiência (XP) ao completar
missões. O nível do jogador é determinado pelo total de XP dividido por uma constante de nível
e ajustado por bônus.
• Comando: Crie um programa que receba a quantidade de XP acumulado, a constante de nível,
o bônus de nível, e dois multiplicadores (um para eventos especiais e outro para equipamentos),
e calcule o nível atual do jogador.

@Lista: 01 - Lógica de Programação
@Autor: Samuel Barbosa Chaves Brandão
@Data: 19/08/2024*/

using System;
class Program
{
    static void Main(string[] args)
    {
        double XPA,XPI1,XPI2,TI1,TI2,N1,final;

        System.Console.WriteLine("O VALOR DE XP ACUMULADO");
        double.TryParse(Console.ReadLine(), out XPA);

        System.Console.WriteLine("QUAL O XP CONCEDIDO PELO PRIMEIRO TIPO DE INIMIGO");
        double.TryParse(Console.ReadLine(), out XPI1);

        System.Console.WriteLine("QUAL O XP CONCEDIDO PELO SEGUNDO TIPO DE INIMIGO");
        double.TryParse(Console.ReadLine(), out XPI2);

        System.Console.WriteLine("QUAL O VALOR DE CADA TIPO DE INIMIGO DERROTADO 1?");
        double.TryParse(Console.ReadLine(), out TI1);

        System.Console.WriteLine("QUAL O VALOR DE CADA TIPO DE INIMIGO DERROTADO 2?");
        double.TryParse(Console.ReadLine(), out TI2);

        System.Console.WriteLine("QUAL A CONSTANTE DE NIVEL?: ");
        double.TryParse(Console.ReadLine(), out N1);

        XPI1 = XPI1 * TI1;
        XPI2 = XPI2 * TI2;
        XPA = XPI1 + XPI2 + XPA;
        final = XPA/N1;

        System.Console.WriteLine("o xp total é de: " + Math.Floor(XPA));
        System.Console.WriteLine("o nível é de: "+ Math.Floor(final));

        System.Console.WriteLine("APERTE ENTER PARA SAIR");
        Console.ReadLine();
        
    }
}