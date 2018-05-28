using RevendaDeCarro.model;
using System;
using System.Collections.Generic;

namespace RevendaDeCarro
{
    class Program
    {
        public static List<Marca> marcas = new List<Marca>();
        public static List<Carro> carros = new List<Carro>();
        static void Main(string[] args)
        {
            int opcao = 0;

            cargaInicialDaAplicacao();
            

            while(opcao != 7)
            {
                Console.Clear();
                Tela.mostraMenu();

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Opcão inválida! " + e.Message);
                    opcao = 0;
                }

                Console.WriteLine();

                if (opcao == 1)
                {
                    Tela.listaMarcas();
                }
                else if(opcao == 2)
                {
                    try
                    {
                        Tela.listaCarros();
                    }
                    catch(ModelException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if(opcao == 3)
                {
                    try
                    {
                        Tela.cadastrarMarca();
                    }
                    catch(ModelException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if(opcao == 4)
                {
                    try
                    {
                        Tela.cadastrarCarro();
                    }
                    catch(ModelException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if(opcao == 5)
                {
                    try
                    {
                        Tela.cadastrarAcessorio();
                    }
                    catch(ModelException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 6)
                {
                    try
                    {
                        Tela.mostraDetalheCarro();
                    }
                    catch(ModelException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (opcao == 7)
                {
                    Tela.encerrarPrograma();
                }
                else
                {
                    Console.WriteLine("Opção invalida!");
                }

                Console.ReadLine();
            }

        }

        static void cargaInicialDaAplicacao()
        {
            /*
             * INICIALIZA COM 2 MARCAS E 3 CARROS PARA CADA MARCA 
             */

            Marca Volkswagem = new Marca(1001, "Volkswagem", "Alemanha");
            marcas.Add(Volkswagem);
            Volkswagem.adicionaCarros(new Carro(101, "Fusca", 1980, 5000.00, Volkswagem));
            Volkswagem.adicionaCarros(new Carro(102, "Golf", 2016, 60000.00, Volkswagem));
            Volkswagem.adicionaCarros(new Carro(103, "Fox", 2017, 30000.00, Volkswagem));
            carros.Add(new Carro(101, "Fusca", 1980, 5000.00, Volkswagem));
            carros.Add(new Carro(102, "Golf", 2016, 60000.00, Volkswagem));
            carros.Add(new Carro(103, "Fox", 2017, 30000.00, Volkswagem));

            Marca GM = new Marca(1002, "General Motors", "Estados Unidos");
            marcas.Add(GM);
            GM.adicionaCarros(new Carro(104, "Cruze", 2016, 30000.00, GM));
            GM.adicionaCarros(new Carro(105, "Cobalt", 2015, 25000.00, GM));
            GM.adicionaCarros(new Carro(106, "Cobalt", 2017, 35000.00, GM));
            carros.Add(new Carro(104, "Cruze", 2016, 30000.00, GM));
            carros.Add(new Carro(105, "Cobalt", 2015, 25000.00, GM));
            carros.Add(new Carro(106, "Cobalt", 2017, 35000.00, GM));
        }
    }
}
