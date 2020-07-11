using System;

namespace ExercicioFixacaoExcecoes.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base (message)
        {

        }
    }
}
