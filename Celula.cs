using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5
{
    class Celula
    {
        private Estudante elemento;
        private Celula prox;

        public Celula(Estudante elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }
        public Celula()
        {
            this.elemento = null;
            this.prox = null;
        }
        public Celula Prox
        {
            get { return prox; }
            set { prox = value; }
        }
        public Estudante Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }
    }
}
