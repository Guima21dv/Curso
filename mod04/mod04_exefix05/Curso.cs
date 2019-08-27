using System;
using System.Collections.Generic;

namespace mod04_exefix05
{
    class Curso
    {

        public HashSet<int> cods { get; set; }
        public string nome_curso { get; set; }

        public Curso(string nome_curso)
        {
            this.nome_curso = nome_curso;
            this.cods = new HashSet<int>();
        }
    }
}
