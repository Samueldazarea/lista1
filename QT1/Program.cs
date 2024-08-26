/*Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.

@Lista: 01 - Lógica de Programação
@Autor: Samuel Barbosa Chaves Brandão
@Data: 19/08/2024*/
using System;
class Programação
{
    static void Main(string[] args)
    {
    string? nome, idade, nivelinicial, classe, raca;
    System.Console.WriteLine("Escreva seu nome de jogador");
    nome = Console.ReadLine();
    System.Console.WriteLine("Escreva sua idade");
    idade = Console.ReadLine();
    System.Console.WriteLine("Escreva seu nivel inicial do seu jogador");
    nivelinicial = Console.ReadLine();         
    System.Console.WriteLine("Escreva sua classe");
    classe = Console.ReadLine();
    System.Console.WriteLine("Escreva a raça do jogador");
    raca = Console.ReadLine();
    System.Console.WriteLine("Nome: \n" + nome, "idade: \n" + idade,"nivel inicial: \n"+ nivelinicial,"classe: \n"+classe, "raça: \n"+ raca);
    Console.ReadLine();
   
    }

}