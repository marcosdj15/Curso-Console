using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, operacao;
            string cliente,produto;
            Console.Clear();
            Console.WriteLine("1-Cliente");
            Console.WriteLine("2-Produto");
            Console.WriteLine("3-Sair");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                
                case 1:
                    Console.WriteLine("1-Cadastrar Cliente");
                    Console.WriteLine("2-Consultar Cliente");
                    break;
                    
                case 2:
                    Console.WriteLine("1-Cadastrar Produto");
                    Console.WriteLine("2-consultar Produto");
                    break;
                case 3:
                    Console.WriteLine("Saindo.....");
                    break;       
            default :
                    Console.WriteLine("Operação Inválida");
                    break;

                    if ((opcao.Equals(1)))
                    {
                        operacao = Convert.ToInt32(Console.ReadLine());
                        if ((operacao.Equals(1)))
	                     {
                            Console.WriteLine("Informe o Nome");
                            cliente = Console.ReadLine();
	                     }
                        else if ((operacao.Equals(2)))
	                    {
		                   Console.WriteLine("Nome do Cliente"+cliente);
                            Console.ReadKey();
	                    }
                        else
                        {
                            Console.WriteLine("Opção Inválida");
                        }
                           
                    }
                    else if ((opcao.Equals(2)))
	                {
		               operacao = Convert.ToInt32(Console.ReadLine());
                        if ((operacao.Equals(1)))
	                    {
		                   Console.WriteLine("Digite o Nome do Produto");
                            produto = Console.ReadLine();
	                    }
                        else if((operacao.Equals(2)))
                        {
                            Console.WriteLine("Nome do Produto"+produto);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Opção Inválida");
                        }
                           
	                }
            }
        }
    }
}
