using System;
using System.Collections.Generic;
using RevendaDeCarro.model;

namespace RevendaDeCarro
{
    /// <summary>
    /// Classe que interage com o usuário
    /// </summary>
    class Tela
    {
        public static void mostraMenu()
        {
            Console.WriteLine("-----------------MENU----------------");
            Console.WriteLine("1 – Listar marcas");
            Console.WriteLine("2 – Listar carros de uma marca ordenadamente");
            Console.WriteLine("3 – Cadastrar marca");
            Console.WriteLine("4 – Cadastrar carro");
            Console.WriteLine("5 – Cadastrar acessório");
            Console.WriteLine("6 – Mostrar detalhes de um carro");
            Console.WriteLine("7 – Sair");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite a opção desejada: ");
            Console.ResetColor();
        }

        public static void listaMarcas()
        {
            Console.WriteLine("LISTAGEM DE MARCAS:");
            foreach (Marca marca in Program.marcas)
                Console.WriteLine(marca);
        }

        public static void listaCarros()
        {
            Console.Write("Digite o código da marca: ");
            int codMarca = int.Parse(Console.ReadLine());
            
            int pos = Program.marcas.FindIndex(x => x.codigo == codMarca);
            if (pos == -1)
                throw new ModelException("Nenhuma marca encontrada.");

            if (Program.marcas[pos].carros.Count == 0)
                throw new ModelException(Program.marcas[pos].nome + ":  não encontrado nenhum carro.");

            foreach(Carro carro in Program.marcas[pos].carros)
                Console.WriteLine(carro.ToString());
        }

        public static void cadastrarMarca()
        {
            Console.WriteLine("digite os dados da marca:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("País de origem: ");
            string pais = Console.ReadLine();
            Console.WriteLine();

            Program.marcas.Add(new Marca(codigo, nome, pais));
            Console.WriteLine("Marca cadastrada com sucesso!");
        }

        public static void cadastrarCarro()
        {
            Console.WriteLine("Digite os dados do carro: ");
            Console.Write("Marca (código): ");
            int codMarca = int.Parse(Console.ReadLine());
            
            int pos = Program.marcas.FindIndex(x => x.codigo == codMarca);
            if (pos == -1)
                throw new ModelException("Nenhuma marca encontrada.");

            Console.Write("Código do carro: ");
            int codCarro = int.Parse(Console.ReadLine());

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Preço Básico: ");
            double preco = double.Parse(Console.ReadLine());

            Carro carro = new Carro(codCarro, modelo, ano, preco, Program.marcas[pos]);

            Program.marcas[pos].adicionaCarros(carro);

            Console.WriteLine("Carro cadastrado com sucesso!");
        }

        public static void cadastrarAcessorio() { }

        public static void mostraDetalheCarro() { }
        
        public static void encerrarPrograma() { }

    }
}
