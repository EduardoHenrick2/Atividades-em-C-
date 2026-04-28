using System;

namespace Atividade_02 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um numero:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"O fatorial de {n} é {fatorial(n)}.");
        }
        
        static int fatorial(int n) {
            if(n == 0) return 0;

            else if (n == 1) return 1;

            else return n * fatorial(n-1);            
        }
    }

}