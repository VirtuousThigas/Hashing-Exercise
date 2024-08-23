using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5
{
    class Lista
    {
        private Celula primeiro, ultimo;
        public Lista()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }
        public void InserirFim(Estudante x)
        {
            ultimo.Prox = new Celula(x);
            ultimo = ultimo.Prox;
        }
        public Estudante Pesquisar(int matricula)
        {
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                if (i.Elemento.Matricula == matricula)
                {
                    return i.Elemento;
                }
            }
            return null;
        }
        public Estudante Remover(int matricula)
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro!");
            }
            else
            {
                Celula tmp = primeiro;
                for (Celula i = primeiro.Prox; i != null; i = i.Prox)
                {
                    if (i.Elemento.Matricula == matricula)
                    {
                        tmp.Prox = i.Prox;
                        i.Prox = null;
                        return i.Elemento;
                    }
                    tmp = i;
                }
                throw new Exception("Elemento não encontrado!");
            }
        }
        public int Tamanho()
        {
            int tam = 0;
            for (Celula i = primeiro; i != ultimo; i = i.Prox)
            {
                tam++;
            }
            return tam;
        }
    }

}
