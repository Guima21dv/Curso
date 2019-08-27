using System;
using System.Collections.Generic;

using System.Text;

namespace sec11_criando_excecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
