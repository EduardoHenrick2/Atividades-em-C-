using System;
using atividade_8;

namespace atividade_8
{
    class Elemento
    {
        public int Num;
        public Elemento Prox;

        public Elemento()
        {
            Prox = null;
            Num = 0;
        }
    }

    class Pilha
    {
        private Elemento Topo;
        private Elemento Aux;

        public Pilha()
        {
            Topo = null;
        }

        public void Inserir(int x)
        {
            Elemento Novo = new Elemento();

            Novo.Num = x;

            Novo.Prox = Topo;
            Topo = Novo;
        }

        public void MostrarPilha()
        {
            if (Topo == null)
            {
                Console.WriteLine("A pilha está vazia!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Topo");

                Aux = Topo;

                while (Aux != null)
                {
                    Console.WriteLine($"{Aux.Num,5}");

                    Aux = Aux.Prox;
                }
            }
        }
        public int Retirar()
        {
            if (Topo == null)
            {
                Console.WriteLine("A Pilha não possui elementos!");
                Console.ReadKey();
                return null;
            }
            else
            {
                int valorRetirado = Topo.Num;
                Topo = Topo.Prox;
                return valorRetirado;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Pilha MinhaPilha = new Pilha();

            MinhaPilha.Inserir(6);
            MinhaPilha.Inserir(2);
            MinhaPilha.Inserir(7);
            MinhaPilha.Inserir(9);
            MinhaPilha.Inserir(3);

            MinhaPilha.MostrarPilha();

            MinhaPilha.Retirar();

            MinhaPilha.MostrarPilha();

        }
    }
}

