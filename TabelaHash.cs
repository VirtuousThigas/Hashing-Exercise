using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5
{
    class TabelaHash
    {
        public Lista[] tabela;
        public TabelaHash(int m)
        {
            tabela = new Lista[m];
            for (int i = 0; i < m; i++)
            {
                tabela[i] = new Lista();
            }
        }
        private int FuncaoHash(int x)
        {
            return x % tabela.Length;
        }
        public Estudante Pesquisar(int matricula)
        {
            return tabela[FuncaoHash(matricula)].Pesquisar(matricula);
        }
        public void Inserir(Estudante x)
        {
            if (Pesquisar(x.Matricula) != null)
            {
                throw new Exception("Erro ao inserir");
            }
            else
            {
                tabela[FuncaoHash(x.Matricula)].InserirFim(x);
            }
        }
        public void Remover(int matricula)
        {
            if (Pesquisar(matricula) == null)
            {
                throw new Exception("Erro ao remover!");
            }
            else
            {
                tabela[FuncaoHash(matricula)].Remover(matricula);
            }
        }
    }

}
