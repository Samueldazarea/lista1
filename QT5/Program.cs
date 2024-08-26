/*Questão 5: Cálculo de Distância Percorrida
• Contextualização: Um veículo no jogo percorre uma certa distância em um tempo determinado.
• Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois
multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a
distância total percorrida.

@Lista: 01 - Lógica de Programação
@Autor: Samuel Barbosa Chaves Brandão
@Data: 19/08/2024*/

using System;
class Program
{
    static void Main(string[] args)
    {

     double VV, TV, CC, EV, final;

     System.Console.WriteLine("O VALOR DA VELOCIDADE DO VEICULO");
     double.TryParse(Console.ReadLine(), out VV);

     System.Console.WriteLine("O VALOR DO TEMPO DE VIAGEM");
     double.TryParse(Console.ReadLine(), out TV);

     System.Console.WriteLine("O VALOR DA VELOCIDADE DO VEICULO");
     double.TryParse(Console.ReadLine(), out CC);

     System.Console.WriteLine("O VALOR DA VELOCIDADE DO VEICULO");
     double.TryParse(Console.ReadLine(), out EV);

     final = ((VV*TV)*CC)*EV;
     System.Console.WriteLine("PONTUAÇÃO FINAL: "+ final);
     Console.ReadLine();
    }
}