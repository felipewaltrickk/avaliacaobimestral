using System;
using System.Collections.Generic;
using System.Globalization;

namespace trabprog1
{
    class Program
    {
        private static List<Carro> listaCarro = new List<Carro>();

        static void Main(string[] args)
        {
            Boolean continua = true;
  
            do
            {
                Console.WriteLine("Menu de cadastro: ");
                Console.WriteLine("1: Incluir");
                Console.WriteLine("2: Alterar");
                Console.WriteLine("3: Excluir");
                Console.WriteLine("4: Listar");
                Console.WriteLine("5: Pesquisar");
                Console.WriteLine("9: Sair");
                Console.WriteLine("Quantidade de carros cadastrados: " + listaCarro.Count);
                Console.Write("Qual sua opção? ");
                int cont = listaCarro.Count;
                string opc = Console.ReadLine();
                Console.WriteLine(opc + "?" + " ok, vamos lá então.");

                switch (opc)
                {
                    case "1":
                        Console.Clear();
                            Console.WriteLine("Incluir:");

                        listaCarro.Add(incluirCarro());
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Alterar");

                        if (listaCarro.Count == 0)
                        {
                            Console.WriteLine("Desculpe, não há nada cadastrado no sistema para ser alterado.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Write("Digite a ID do carro que deseja alterar: ");
                            string alteracao = Console.ReadLine();
                            Carro auxiliador = listaCarro.Find(x => x.ID == alteracao);
                            if (auxiliador == null)
                            {
                                Console.WriteLine("Desculpe, não conseguimos encontrar essa ID no sistema.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            if (auxiliador != null)
                            {
                                Console.Write("Digita sua nova ID: ");
                                Carro modificar = listaCarro.Find(x => x.ID == alteracao);
                                modificar.ID = Console.ReadLine();

                                Console.Write("Digite o modelo do carro: ");
                                Carro modificar1 = listaCarro.Find(x => x.ID == alteracao);
                                modificar.Modelo = Console.ReadLine();

                                Console.Write("Digite a quilometragem desse carro: ");
                                Carro modificar2 = listaCarro.Find(x => x.ID == alteracao);
                                modificar.Quilometragem = Console.ReadLine();

                                Console.Write("Digite o ano desse carro: ");
                                Carro modificar3 = listaCarro.Find(x => x.ID == alteracao);
                                modificar.Ano = Console.ReadLine();
                                Console.ReadLine();

                                Console.Write("Digite o valor dos juros mensais desse carro se for comprado à prazo: ");
                                Carro modificar4 = listaCarro.Find(x => x.ID == alteracao);
                                modificar.Juros = float.Parse(Console.ReadLine());

                                Console.Write("Digite por favor a data de acesso ao sistema: ");
                                Carro modificar5 = listaCarro.Find(x => x.ID == alteracao);
                                modificar.Data = Console.ReadLine();

                                Console.Clear();
                            }
                          }
                        break;

                    case "3":
                        Console.Clear();
                             Console.WriteLine("Excluir");

                        if (listaCarro.Count == 0)
                        {
                            Console.WriteLine("Desculpe, não há nada cadastrado no sistema para você excluir.");
                        }
                        else
                        {
                            Console.Write("Qual ID deseja excluir? ");
                            string guardar = Console.ReadLine();
                            string escolha;
                            Console.Write("Se encontrarmos seu registro, tem certeza que deseja excluir? Sim/Não? ");
                            escolha = Console.ReadLine();

                            if (escolha == "Sim")
                            {
                                Console.WriteLine("Status da operação: ");
                            }
                                Console.Clear();
                            if (escolha == "Não")
                            {
                                Console.WriteLine("Ok, nada foi alterado. ");
                                Console.WriteLine();

                                break;
                            }
                            if (listaCarro.Remove(listaCarro.Find(x => x.ID == guardar)))
                            {
                                Console.WriteLine("Excluído com sucesso");
                            }
                            else
                            {
                                Console.WriteLine("Registro não encontrado!");
                            }                   
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "4":
                        Console.Clear();
                            Console.WriteLine("Listar");

                        if (listaCarro.Count == 0)
                        {
                            Console.WriteLine("Desculpe, não encontramos nada em nosso sistema.");
                        }
                        else
                        {
                        listar();
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "5":
                        Console.Clear();
                            Console.WriteLine("Pesquisar: ");

                        Console.Write("Qual o modelo do carro que você está procurando? ");
                        string pesquisar = Console.ReadLine();
                        Carro aux = listaCarro.Find(x => x.Modelo == pesquisar);
                        if (aux == null)
                        {
                            Console.Write("Desculpe, não encontramos o que você está procurando.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write("Encontramos alguma coisa por aqui: " + aux);
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "9":
                        Console.Clear();
                        Console.WriteLine("Deseja mesmo sair? Sim ou Não");
                        string escolhaopc9;
                        escolhaopc9 = Console.ReadLine();

                        if (escolhaopc9 == "Sim")
                        {
                            Console.WriteLine("Sair: Aplicação encerrada.");
                            continua = false;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        if (escolhaopc9 == "Não")
                        {
                            Console.Clear();
                            break;
                        }
                         break;

                    default:
                        Console.Clear();
                            Console.WriteLine("Opção inválida.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (continua);
        }

        private static Carro incluirCarro()
        {
            Carro carro = new Carro();

            Console.Write("ID: ");
            carro.ID = Console.ReadLine();
            Console.Write("Modelo do carro: ");
            carro.Modelo = Console.ReadLine();
            Console.Write("Quilometragem: ");
            carro.Quilometragem = Console.ReadLine();
            Console.Write("Ano: ");
            carro.Ano = Console.ReadLine();
            Console.Write("Qual o valor dos juros mensais desse carro se for comprado à prazo? ");
            carro.Juros = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Por favor, digite a data em que o sistema está sendo utilizado: ");
            carro.Data = Console.ReadLine();
            return carro;
                                    
        }

        private static void listar()
        {
            foreach(Carro carro in listaCarro)
            {
                Console.WriteLine(carro);
            }
        }
    }
}

