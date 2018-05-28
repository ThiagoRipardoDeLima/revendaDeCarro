using System;

namespace RevendaDeCarro
{
    class ModelException : Exception
    {
        public ModelException(string mensagem) : base(mensagem) { }
    }
}
