using System;

namespace Atividade_04 { //objetivo: criar e manipular uma fila (Queue)

    class MinhaFila {
        private Queue<int> _fila;

        public MinhaFila() {
            _fila = new Queue<int>();
        }
        public void enqueue(int valor) {
            _fila.Enqueue(valor);
        }
        public void dequeue() {
            _fila.Dequeue();
        }
        public int front() {
            return _fila.Peek();
        }
        public bool isEmpty() {
            return _fila.Count == 0;
        }
        public int size() {
            return _fila.Count;
        }
        public void print() {
            foreach (var item in _fila) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    class Program {
        static void Main(string[] args) {
            int opcaoSistema, opcaoFila;
            bool acabarSistema = false;
            
            MinhaFila minhaFila = null; 

            while (!acabarSistema) {
                Console.WriteLine("\n=== MENU PRINCIPAL ===");
                Console.WriteLine("1. Acessar a Fila (Criar / Manipular)");
                Console.WriteLine("2. Sair do Sistema");
                Console.Write("Escolha: ");
                
                while(!int.TryParse(Console.ReadLine(), out opcaoSistema)); 

                switch (opcaoSistema) {
                    case 1: 
                        if (minhaFila == null) {
                            minhaFila = new MinhaFila();
                            Console.WriteLine(">> Fila criada com sucesso! <<");
                        }

                        bool voltarMenuPrincipal = false;
                        while (!voltarMenuPrincipal) {
                            Console.WriteLine("\n--- SUBMENU DA FILA ---");
                            Console.WriteLine("1. Adicionar elemento (Enqueue)");
                            Console.WriteLine("2. Remover elemento (Dequeue)");
                            Console.WriteLine("3. Ver primeiro elemento (Front)");
                            Console.WriteLine("4. Verificar se vazia");
                            Console.WriteLine("5. Ver tamanho da fila");
                            Console.WriteLine("6. Mostrar fila");
                            Console.WriteLine("7. Voltar ao Menu Principal");
                            Console.Write("Escolha: ");
                            
                            while(!int.TryParse(Console.ReadLine(), out opcaoFila)); 

                            switch (opcaoFila) {
                                case 1:
                                    Console.Write("Digite o valor a ser adicionado: ");
                                    int valor = int.Parse(Console.ReadLine());
                                    minhaFila.enqueue(valor);
                                    Console.WriteLine($"Valor {valor} adicionado!");
                                    break;
                                case 2:
                                    if (!minhaFila.isEmpty()) {
                                        int removido = minhaFila.front();
                                        minhaFila.dequeue();
                                        Console.WriteLine($"Valor {removido} removido!");
                                    } else {
                                        Console.WriteLine("Fila vazia!");
                                    }
                                    break;
                                case 3:
                                    if (!minhaFila.isEmpty()) {
                                        Console.WriteLine($"Primeiro elemento: {minhaFila.front()}");
                                    } else {
                                        Console.WriteLine("Fila vazia!");
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine(minhaFila.isEmpty() ? "Fila vazia!" : "Fila com elementos!");
                                    break;
                                case 5:
                                    Console.WriteLine($"Tamanho da fila: {minhaFila.size()}");
                                    break;
                                case 6:
                                    Console.Write("Valores na fila: ");
                                    minhaFila.print();
                                    break;
                                case 7:
                                    voltarMenuPrincipal = true;  
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }
                        }
                        break;

                    case 2:
                        acabarSistema = true;
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    
                    default:
                        Console.WriteLine("Opção inválida no menu principal!");
                        break;
                }
            }
        }
    }
}