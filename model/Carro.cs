using System;
using System.Collections.Generic;
using System.Globalization;

namespace RevendaDeCarro.model
{
    class Carro : IComparable
    {
        public int codigo { get; private set; }
        public string modelo { get; private set; }
        public int ano { get; private set; }
        public double precoBasico { get; private set; }
        public Marca marca { get; private set; }
        public List<Acessorio> acessorios { get; private set; }

        public Carro(int codigo, string modelo, int ano, double precoBasico, Marca marca)
        {
            this.codigo         = codigo;
            this.modelo         = modelo;
            this.ano            = ano;
            this.precoBasico    = precoBasico;
            this.marca          = marca;
            acessorios          = new List<Acessorio>();
        }

        public double precoTotal()
        {
            double custoAcessorio = 0.00;
            foreach (Acessorio acessorio in acessorios)
                custoAcessorio += acessorio.preco;

            return precoBasico + custoAcessorio;
        }
        public void adicionarAcessorio(Acessorio acessorio)
        {
            acessorios.Add(acessorio);
        }

        public override string ToString()
        {
            string carro = "";

            carro = codigo + ", " + modelo + ", Ano: " + ano
                + ", Preço básico: " + precoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + ", Preço total: " + precoTotal().ToString("F2", CultureInfo.InvariantCulture)
                + "\n";

            if (acessorios.Count > 0)
            {
                carro += "Acessórios: \n";
                foreach (Acessorio acessorio in acessorios)
                    carro += acessorio + "\n";
            }
            return carro;
        }
        
        public int CompareTo(object obj)
        {
            Carro outroCarro = (Carro)obj;
            int resultado = modelo.CompareTo(outroCarro.modelo);
            if (resultado != 0)
                return resultado;

            return -precoBasico.CompareTo(outroCarro.precoTotal());
        }
    }
}
