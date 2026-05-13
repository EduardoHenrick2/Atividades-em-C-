using System;

namespace Fila
{
    class Fila
    {
        private Elemento Inicio;
        private Elemento Fim;
        private Elemento Aux;

        public Fila()
        {
            Inicio = null;
            Fim = null;
        }

        public void Inserir(int x)
        {
            Elemento Novo = new Elemento();

            Novo.Num = x;
            Novo.Prox = null;

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

        public void Retirar()
        {
            if (Inicio == null)
            {
                Console.WriteLine("Não tem elementos na Fila");
                Console.ReadKey();
            }
            else
            {
                Inicio = Inicio.Prox;
            }
        }
    }
}