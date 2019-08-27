using System;
using System.Collections.Generic;
using System.Text;

namespace mod04_exefix02
{
    class Quarto
    {
        public string nome_inquilino;
        public string email;

        public Quarto(string nome_inquilino,string email)
        {
            this.nome_inquilino = nome_inquilino;
            this.email = email;
        }

        public override string ToString()
        {
            return nome_inquilino + ", " + email;
        }

    }
}
