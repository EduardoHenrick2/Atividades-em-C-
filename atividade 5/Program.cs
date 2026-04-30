using System;
using System.Security.Cryptography.X509Certificates;

namespace atividade5
{
    class MinhaLista<T> // Classe genérica para criar uma lista de qualquer tipo
    {
        private T[] elementos;
        private int quantidade;
        public MinhaLista(int tamanho)
        {
            elementos = new T[tamanho];
            quantidade = 0;
        }
        public void Redimensionar()
        {
            T[] novaLista = new T[elementos.Length * 2];

            for (int i = 0; i < elementos.Length; i++)
            {
                novaLista[i] = elementos[i];
            }

            elementos = novaLista;
        }
        public void AdicionarPrimeiro(T elemento)
        {
            if (quantidade == elementos.Length)
            {
                Redimensionar();
            }
            for (int i = quantidade; i > 0; i--)
            {
                elementos[i] = elementos[i - 1];
            }
            elementos[0] = elemento;
            quantidade++;
        }
        public void AdicionarUltimo(T elemento)
        {
            if (quantidade == elementos.Length)
            {
                Redimensionar();
            }
            elementos[quantidade] = elemento;
            quantidade++;
        }
        public void AdicionarPosicao(T elemento, int posicao)
        {
            if (posicao < 0 || posicao > quantidade)
            {
                throw new ArgumentOutOfRangeException(nameof(posicao)); // Lança uma exceção se a posição for inválida (menor que 0 ou maior que a quantidade atual de elementos)
                return;
            }

            if (quantidade == elementos.Length)
            {
                Redimensionar();
            }
            for (int i = quantidade; i > posicao; i--)
            {
                elementos[i] = elementos[i - 1];
            }
            elementos[posicao] = elemento;
            quantidade++;
        }
        public void RemoverPrimeiro()
        {
            if (quantidade = 0) return;

            for (int i = 0; i < quantidade - 1; i++)
            {
                elementos[i] = elementos[i + 1];
            }
            quantidade--;
        }
        public void RemoverUltimo()
        {
            if (quantidade > 0)
            {
                quantidade--;
            }
        }
        public void Remover(T valor)
        {
            int posicao = -1;
            for (int i = 0; i < quantidade; i++)
            {
                if (Equals(elementos[i], valor))
                {
                    posicao = i;
                    break;
                }
            }
            if (posicao != -1)
            {
                for (int i = posicao; i < quantidade - 1; i++)
                {
                    elementos[quantidade - 1] = default(T);
                    quantidade--;
                }
            }
        }
        public void MostrarLista()
        {
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine(elementos[i]);
            }
        }
        public void LimparLista()
        {
            for (int i = 0; i < quantidade; i++)
            {
                elementos[i] = default(T); // Atribui o valor padrão do tipo T (null para tipos de referência, 0 para tipos numéricos, etc.)
            }
            quantidade = 0;
        }
        public int ContarElementos()
        {
            return quantidade;
        }
        public int Buscar(T valor)
        {
            for (int i = 0; i < quantidade; i++)
            {
                if (Equals(elementos[i], valor))
                {
                    Console.WriteLine($"Valor encontrado na posição {i}");
                    return i;
                }
            }
            Console.WriteLine("Valor não encontrado");
            return -1;
        }
        public T this[int index]
        /* Vai possibilitar acessar os elementos da lista usando a sintaxe de índice, como lista[0], lista[1], etc. */
        {
            get
            {
                if (index < 0 || index >= quantidade)
                    throw new IndexOutOfRangeException("Índice fora do alcance");

                return elementos[index];

                /* Para quem não conhece muito o throw uma outra forma de ultilizar seria
                if(index < 0 || index >= quantidade)
                {
                    Console.WriteLine("Índice fora do alcance");
                    return null; // ou algum valor padrão, vai depender do tipo T!!!
                }
                */
            }

            set
            {
                if (index < 0 || index >= quantidade)
                    throw new IndexOutOfRangeException("Índice fora do alcance");

                elementos[index] = value;
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