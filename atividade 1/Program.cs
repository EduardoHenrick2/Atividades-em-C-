using System;

namespace Atividade_01  
{
    class Program {
        static void Main(string[] args) {
            int n = valorN();
            Console.Write($"{Soma(n)}");
        }


        public static int valorN() {
            Console.Write("Digite um valor para N: ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }

        public static int Soma(int n) {
            if (n == 0) return 0;

            else if (n == 1) return 1;  
            
            else return (n + Soma(n -1));
            
        }
    }

}