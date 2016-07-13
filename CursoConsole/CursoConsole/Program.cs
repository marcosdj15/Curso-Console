using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CursoConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListCli = new List<string>();
            ArrayList ListPrd = new ArrayList();
            String cliente = "", produto = "", Noprd = "";
            int opcao, operacao;
            do
            {
                Console.Clear();
                Console.WriteLine("1- Cliente");
                Console.WriteLine("2- Produto");
                Console.WriteLine("3- Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("1- Cadastrar Cliente");
                        Console.WriteLine("2- Consultar Cliente");
                        Console.WriteLine("3- Consultar Cliente Por Nome:");
                        Console.WriteLine("4- Remover");
                        break;
                    case 2:
                        Console.WriteLine("1- Cadastrar Produto");
                        Console.WriteLine("2- Consultar Produto");
                        Console.WriteLine("3- Consultar Produto por Nome");
                        Console.WriteLine("4- Remover");
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Operação Inválida!");
                        break;
                }
                if ((opcao.Equals(1)))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao.Equals(1))
                    {
                        Console.Write("Informe o nome:");
                        cliente = Console.ReadLine();
                        ListCli.Add(cliente);
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                        Console.ReadKey();
                       
                    }
                    else if ((operacao.Equals(2)))
                    {
                        foreach (var cli in ListCli)
                        {
                            Console.WriteLine("Nome do Cliente:" + cli);
                        }
                       
                        Console.ReadKey();
                    }
                    else if(operacao.Equals(3))
                    {
                        Console.WriteLine("Digite O nome do Cliente");
                       String Nocli = Console.ReadLine();
                        foreach (var cli in ListCli)
                        {
                            if (Nocli.Equals(cli))
                            {
                                Console.WriteLine("Achei " + Nocli);
                                Console.ReadKey();
                            }
                            
                            else
                            {
                                Console.WriteLine("Não Achei");
                                Console.ReadKey();
                            }
                        }
                    }
                    else if (operacao.Equals(4))
                    {
                        Console.WriteLine("Digite o Nome para Remover");
                        String recli = Console.ReadLine();
                        foreach (var cli in ListCli)
	                    {
                           if(cli.Equals(recli))
                           {
                               
                               ListCli.Remove(cli);
                               Console.WriteLine("Removendo.....");
                               break;
                           }
                           else
                           {
                               
                              Console.WriteLine("Nome não Encontrado");
                              Console.ReadKey();
                           }
	                    }
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
                }
                else if ((opcao.Equals(2)))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao.Equals(1))
                    {
                        Console.Write("Informe  o nome:");
                        produto = Console.ReadLine();
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                        ListPrd.Add(produto);
                        
                    }
                    else if ((operacao.Equals(2)))
                    {
                        foreach (var prd in ListPrd)
                        {
                            Console.WriteLine("Descrição: " + prd);
                        }
                     
                        Console.ReadKey();
                    }
                    else if (operacao.Equals(3))
                    {
                        Console.WriteLine("Digite O nome do Produto");
                        Noprd = Console.ReadLine();
                        foreach (var pdr in ListPrd)
                        {
                            if (Noprd.Equals(pdr))
                            {
                                Console.WriteLine("Achei " + Noprd);
                                Console.ReadKey();
                            }
                            
                            else
                            {
                                Console.WriteLine("Não Achei");
                                Console.ReadKey();
                            }
                        }
                    }
                    else if (operacao.Equals(4))
                    {
                        Console.WriteLine("Digite o Nome do Produto");
                        String prdAux = Console.ReadLine();
                        bool remove = ListPrd.Remove(prdAux);
                        if (remove)
                        {
                            Console.WriteLine("Produto Removido com Sucesso !!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
                }
            } while (opcao != 3);
        }

    }
}
