using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projPOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contador contador;
            contador = new Contador();
            int opcao;

            do
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("VALOR DO CONTADOR: {0}", contador.getValor());
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar");
                Console.WriteLine("2. Subtrair");
                Console.WriteLine("3. Adicionar 5");
                Console.WriteLine("4. Subtrair 5");
                Console.WriteLine("5. Zerar");
                Console.Write("Digite sua opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        {
                            contador.adicionar();
                            break;
                        }
                    case 2:
                        {
                            contador.subtrair();
                            break;
                        }
                    case 3:
                        {
                            contador.adicionar(5);
                            break;
                        }
                    case 4:
                        {
                            contador.subtrair(5);
                            break;
                        }

                    case 5:
                        {
                            contador.zerar();
                            break;
                        }
                }
            }
            while (opcao != 0);
        }
    }
}
