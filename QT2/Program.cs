/*Questão 2: Pontuação Final
• Contextualização: No final de uma missão em um jogo, a pontuação do jogador é calculada com
base nos inimigos derrotados e pontos adicionais.
• Comando: Desenvolva um programa que receba o número de inimigos derrotados, a pontuação
por inimigo, bônus por missão, e dois multiplicadores (um para tipo de inimigo e outro para
dificuldade), e então calcule e exiba a pontuação final.

@Lista: 01 - Lógica de Programação
@Autor: Samuel Barbosa Chaves Brandão
@Data: 19/08/2024*/

using System;
class Program
{
static void Main()
{
double pinig,derrotados,bonus,n1,n2,final;

    System.Console.WriteLine("O numero de inimigos derrotados");
    double.TryParse(Console.ReadLine(), out derrotados);

    System.Console.WriteLine("Qual a pontuação por inimigo");
    double.TryParse(Console.ReadLine(), out pinig);

    System.Console.WriteLine("Qual foi o bonus da missão");
    double.TryParse(Console.ReadLine(), out bonus);  

    System.Console.WriteLine("Qual foi o multiplicador do tipo inimigo");
    double.TryParse(Console.ReadLine(), out n1);

    System.Console.WriteLine("Qual foi o multiplicador de dificuldade");
    double.TryParse(Console.ReadLine(), out n2);
    
    final = (((derrotados*pinig)*n1)*n2)+bonus;
    System.Console.WriteLine("PONTUAÇÃO FINAL:"+final);
    Console.ReadLine();
    
}

}