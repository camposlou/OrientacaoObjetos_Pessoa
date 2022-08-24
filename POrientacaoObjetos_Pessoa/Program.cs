using System;
using POrientacaoObjetos_Pessoa;

namespace PProgOrientadaObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] Cadastro = new String[3, 4];
            Cadastros();
            ImprimirDados();
            void Cadastros()
            {
                for (int linhas = 0; linhas < 3; linhas++)
                {
                    for (int coluna = 0; coluna < 4; coluna++)
                    {
                        switch (coluna)
                        {
                            case 0:
                                Console.WriteLine("Digite o Nome");
                                Cadastro[linhas, coluna] = Console.ReadLine();
                                
                                break;
                            case 1:
                                Console.WriteLine("Digite o data");
                                Cadastro[linhas, coluna] = Console.ReadLine();
                               
                                break;
                            case 2:
                                Console.WriteLine("Digite o cpf");
                                Cadastro[linhas, coluna] = Console.ReadLine();
                               
                                break;
                            case 3:
                                Console.WriteLine("Digite o telefone");
                                Cadastro[linhas, coluna] = Console.ReadLine();
                                Console.WriteLine();
                                
                                break;
                        }
                    }
                }
            }
            void ImprimirDados()
            {
                 Console.ForegroundColor = ConsoleColor.Green;
                 Pessoa pessoa1 = new Pessoa(Cadastro[0, 0], Cadastro[0, 1], Cadastro[0, 2], Cadastro[0, 3]);
                 Console.WriteLine(pessoa1.ToString());
                 Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Pessoa pessoa2 = new Pessoa(Cadastro[1, 0], Cadastro[1, 1], Cadastro[1, 2], Cadastro[1, 3]);
                Console.WriteLine(pessoa2.ToString());
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Pessoa pessoa3 = new Pessoa(Cadastro[2, 0], Cadastro[2, 1], Cadastro[2, 2], Cadastro[2, 3]);
                Console.WriteLine(pessoa3.ToString());
                Console.WriteLine();
            }
        }     
    }
}
