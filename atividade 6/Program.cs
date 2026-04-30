using System;
using System.Security.Cryptography.X509Certificates;

namespace atividade_6
{
    class Elemento
    {
        public int Num;
        Public Elemento Prox;

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
        
        public Lista()
        {
            Inicio = null;
            Fim = null;
            Aux = null;
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
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}