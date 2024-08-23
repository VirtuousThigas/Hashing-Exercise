using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5
{
    class Estudante
    {
        private int matricula;
        private string nome;
        private string curso;
        public Estudante(int matricula, string nome, string curso)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.curso = curso;
        }
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
    }
}
