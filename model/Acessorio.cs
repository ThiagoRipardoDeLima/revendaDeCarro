using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RevendaDeCarro.model
{
    class Acessorio
    {
        public string nome { get; private set; }
        public double preco { get; private set; }
        public Carro carro { get; private set; }

        public Acessorio(string nome, double preco, Carro carro)
        {
            this.nome = nome;
            this.preco = preco;
            this.carro = carro;
        }

        public override string ToString()
        {
            return nome
                + ", Preço: "
                + preco.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
