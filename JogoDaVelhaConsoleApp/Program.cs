using System;
using System.Collections.Generic;

namespace JogoDaVelhaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[3, 3];

            string turno = "X";

            List<string> indexNumero = new List<string> { };

            int index = 1;
            int tentativa = 1;

            Console.WriteLine("-------------------");
            Console.WriteLine("   Jogo Da Velha   ");
            Console.WriteLine("-------------------");

            //Alimentando a matriz.
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = index.ToString();
                    indexNumero.Add(index.ToString());
                    index++;
                }
            }

            //Imprimir a matriz.
            for (int i = 0; i < matriz.GetLength(0); i++)//pega as linhas
            {
                for (int j = 0; j < matriz.GetLength(1); j++)// pega as colunas.
                {
                    Console.Write($"[{matriz[i, j]}]");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\n Você quer jogar [{turno}] em qual posição?");
            string jogada = Console.ReadLine();
            Console.Clear();


            //Começa o Jogo.

            while (tentativa < 9)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("   Jogo Da Velha   ");
                Console.WriteLine("-------------------");

                //Substituir o valor em sua respectiva casa.
                for (int i = 0; i < matriz.GetLength(0); i++)//pega as linhas 
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)//pega as colunas
                    {
                        if (matriz[i, j] == jogada && indexNumero.Contains(jogada))
                        {
                            matriz[i, j] = turno;
                            indexNumero.Remove(jogada);
                        }
                    }
                }

                //Imprimir Matriz.
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write($"[{matriz[i, j]}]");
                    }
                    Console.WriteLine();
                }

                //Condição da vitória nas diagonais.
                if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] ||
                   matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Fim de jogo!!!");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"\nParabéns!!! O ganhador é {turno}.");
                    break;
                }
                //Condição da vitória na horizontal.
                if (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] ||
                   matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] ||
                   matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2])
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Fim de jogo!!!");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"\nParabéns!!! O ganhador é {turno}.");
                    break;
                }

                //Condição da vitória na Vertical.
                if (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] ||
                   matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] ||
                   matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2])
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Fim de jogo!!!");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"\nParabéns!!! O ganhador é {turno}.");
                    break;
                }

                if (turno == "X")
                {
                    turno = "O";
                }
                else
                {
                    turno = "X";
                }

                Console.WriteLine();
                Console.WriteLine($"Você quer jogar [{turno}] em qual posição?");
                jogada = Console.ReadLine();

                while (!indexNumero.Contains(jogada))
                {
                    Console.WriteLine();
                    Console.Write("Jogada inválida. Tente novamente.");
                    jogada = Console.ReadLine();
                }
                tentativa++;
                Console.Clear();
            }

            if (tentativa == 9)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("   Jogo Da Velha   ");
                Console.WriteLine("-------------------");

                for (int i = 0; i < matriz.GetLength(0); i++)//pega as linhas
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)//pega as colunas
                    {
                        Console.WriteLine($"[{matriz[i, j]}]");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Fim de jogo!!!");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"\nQue triste!!! Ninguém ganhou.");
            }
            Console.ReadLine();
        }
    }
}
