using System;
using System.Collections.Generic;

namespace RevendaDeCarro.model
{
    class Marca
    {
        public int codigo { get; private set; }
        public string nome { get; private set; }
        public string pais { get; private set; }
        public List<Carro> carros { get; private set; }

        public Marca(int codigo, string nome, string pais)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.pais = pais;
            carros = new List<Carro>();
        }

        public void adicionaCarros(Carro carro)
        {
            carros.Add(carro);
            carros.Sort();
        }
        
        public override string ToString()
        {
            return codigo
                + ", "
                + nome
                + ", País: "
                + pais
                + ", Numero de carros: "
                + carros.Count;
        }
    }
}
