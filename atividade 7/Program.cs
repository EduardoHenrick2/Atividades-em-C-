using System;
using System.Runtime.CompilerServices;

namespace atividade_7
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

        public void Insere(int x)
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
                Anterior = null;
                Aux = Inicio;

                while (Aux != null && Novo.Num > Aux.Num)
                {
                    Anterior = Aux;
                    Aux = Aux.Prox;
                }
            }
            if (Anterior == null)
            {
                Novo.Prox = Inicio;
                Inicio = Novo;
            }
            else if(Aux == null)
            {
                Fim.Prox = Novo;
                Fim = Novo;
            }
            else
            {
                Anterior.Prox = Novo;
                Novo.Prox = Aux;
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
            Lista lista = new Lista();
            int opc = -1;
            while (opc != 0)
            {
                Console.Clear();
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Mostrar lista");
                Console.WriteLine("3 - Retirar elemento");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");

                if (!int.TryParse(Console.ReadLine(), out opc))
                    opc = -1;

                switch (opc)
                {
                    case 1:
                        Console.Write("Número a inserir: ");
                        if (int.TryParse(Console.ReadLine(), out int val))
                        {
                            lista.Insere(val);
                            Console.WriteLine("Inserido.");
                        }
                        else
                            Console.WriteLine("Valor inválido.");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 2:
                        lista.MostraLista();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Write("Número a retirar: ");
                        if (int.TryParse(Console.ReadLine(), out int rem))
                        {
                            lista.RetiraElemento(rem);
                            Console.WriteLine("Operação concluída.");
                        }
                        else
                            Console.WriteLine("Valor inválido.");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
