using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

namespace atividade_6
{
    class Elemento
    {
        public int Num;
        public Elemento Prox;
  

        public Elemento()
        {
            Num = 0;
            Prox = null;
        }
    }
    class Lista
    {
        private Elemento Inicio;
        private Elemento Fim;
        private Elemento Aux;
        public Elemento Anterior;
        
        public Lista()
        {
            Inicio = null;
            Fim = null;
            Aux = null;
            Anterior = null;
        }

        public void InserirFim(int x)
        {
            Elemento Novo = new Elemento();
            Novo.Num = x;
            if (Inicio == null)
            {
                Inicio = Novo;
                Fim = Novo;
            }
            else
            {
                Fim.Prox = Novo;
                Fim = Novo;
            }
        }

        public void InserirInicio(int x)
        {
            Elemento Novo = new Elemento();

            Novo.Num = x;
            if (Inicio == null)
            {
                Inicio = Novo;
                Fim = Novo;
            }
            else
            {
                Novo.Prox = Inicio;
                Inicio = Novo;
            }
        }
        
        public void MostraLista()
        {
            Console.Clear();

            if (Inicio == null)
            {
                Console.WriteLine("Lista Vazia");
                Console.ReadKey();
            }
            else
            {
                Aux = Inicio;
                while (Aux != null)
                {
                    Console.WriteLine($"{Aux.Num, 7}");
                    Aux = Aux.Prox;
                }
            }
        }

        public void RetiraElemento(int x)
        {
            Aux = Inicio;
            Anterior = null;

            while (Aux != null)
            {
                if (Aux.Num ==x)
                {
                    if (Aux ==Inicio)
                        Inicio = Aux.Prox;
                    else if (Aux == Fim)
                    {
                        Anterior.Prox = null;
                        Fim = Anterior;
                    }
                    else
                    {
                        Anterior.Prox = Aux.Prox;
                    }
                }
                else
                {
                    Anterior = Aux;
                    Aux = Aux.Prox;
                }
            }
        }

    }
    class Program
    {  
        static void Main(string[] args)
        {
            Lista MinhaLista = new Lista();

            MinhaLista.InserirFim(7);
            MinhaLista.InserirFim(13);
            MinhaLista.InserirFim(23);
            MinhaLista.InserirFim(31);

            MinhaLista.MostraLista();

        }
    }
}