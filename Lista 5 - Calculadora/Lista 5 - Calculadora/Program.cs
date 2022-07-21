using System;
using static System.Console;

namespace Projeto_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int calc = 0;
            while (calc == 0){
                WriteLine("Olá!");
                WriteLine("Bem-vindo à sua calculadora particular.");
                    WriteLine("Digite O para utilizar a calculadora ou qualquer outra tecla para sair");
                    calc = int.Parse(ReadLine());
                    if (calc != 0)
                    {
                        WriteLine("Saindo");
                        break;
                    }
                    WriteLine("Qual operação deseja realizar?");
                    WriteLine("Para soma digite (+)");
                    WriteLine("Para subtração digite (-)");
                    WriteLine("Para multiplicação digite (x)");
                    WriteLine("Para divisão digite (/)");

                    string opcaoOperation = ReadLine();

                    WriteLine("Insira o primeiro valor ");
                    float a = float.Parse(ReadLine());
                    WriteLine("Insira o segundo valor");
                    float b = float.Parse(ReadLine());
                    
                    float soma = a + b;
                    float subtracao = a - b;
                    float multiplicacao = a * b;
                    float divisao = a / b;

                    if (b == 0 && opcaoOperation == "/")
                    {
                        WriteLine("Zero não é um divisor, a operação será reiniciada." + "\n");
                        calc = 1;
                    }
                    else {
                    switch (opcaoOperation)
                    {
                        case "+":
                            WriteLine($"O valor da soma é: {soma}\n");
                            break;
                        case "-":
                            WriteLine($"O valor da subtração é: {subtracao}\n");
                            break;
                        case "x":
                            WriteLine($"O valor da multiplicação é: {multiplicacao}\n");
                            break;
                        case "/":
                            WriteLine($"O valor da divisão é: {divisao}\n");
                            break;
                    }

                }

                        
                

            }
                
            
        }
    }
}