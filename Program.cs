using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5
{  
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            bool saida = false;
            TabelaHash novatabela = new TabelaHash(30);
            while (saida == false)
            {
                Console.WriteLine("1- Inserir um estudante");
                Console.WriteLine("2- Remover um estudante");
                Console.WriteLine("3- Pesquisar um estudante");
                Console.WriteLine("4- Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Insira a matricula");
                        int matriculainserir = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o nome do estudante");
                        string nomeinserir = Console.ReadLine();
                        Console.WriteLine("Insira o curso do novo aluno");
                        string cursoinserir = Console.ReadLine();
                        Estudante novoestudante = new Estudante(matriculainserir, nomeinserir, cursoinserir);
                        novatabela.Inserir(novoestudante);
                        break;
                    case 2:
                        Console.WriteLine("Insira a matricula do estudante que deseja remover");
                        int estudanteremover = int.Parse(Console.ReadLine());
                        novatabela.Remover(estudanteremover);
                        break;
                    case 3:
                        Console.WriteLine("Insira a matricula do estudante que deseja pesquisar");
                        int alunopesquisar = int.Parse(Console.ReadLine());
                        Estudante estudante = novatabela.Pesquisar(alunopesquisar);
                        if (estudante != null)
                        {
                            Console.WriteLine("Matricula: " + estudante.Matricula);
                            Console.WriteLine("Nome: " + estudante.Nome);
                            Console.WriteLine("Curso: " + estudante.Curso);
                        }
                        else
                        {
                            Console.WriteLine("Estudante não cadastrado");
                        }
                        break;
                    case 4:
                        saida = true;
                        break;
                }
            }
        }
    }
}
