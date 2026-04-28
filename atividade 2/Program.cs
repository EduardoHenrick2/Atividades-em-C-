using System;

namespace Atividade_02 {

    class MinhaLista {
        private List<int> _lista;

        public MinhaLista() {
            _lista = new List<int>();
        }
        public void push(int valor) {
            _lista.Add(valor);
        }
        public void pop() {
            _lista.RemoveAt(_lista.Count - 1);
        }
        public int peek() {
            return _lista[_lista.Count - 1];
        }
        public void print() {
            foreach (var item in _lista) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    class Program {
        static void Main(string[] args) {
            int opcaoSistema, opcaoLista;
            bool acabarSistema = false;
            
            MinhaLista minhaLista = null; 

            while (!acabarSistema) {
                Console.WriteLine("\n=== MENU PRINCIPAL ===");
                Console.WriteLine("1. Acessar a Lista (Criar / Manipular)");
                Console.WriteLine("2. Sair do Sistema");
                Console.Write("Escolha: ");
                
                while(!int.TryParse(Console.ReadLine(), out opcaoSistema)); 

                switch (opcaoSistema) {
                    case 1: 
                        if (minhaLista == null) {
                            minhaLista = new MinhaLista();
                            Console.WriteLine(">> Lista criada com sucesso! <<");
                        }

                        bool voltarMenuPrincipal = false;
                        while (!voltarMenuPrincipal) {
                            Console.WriteLine("\n--- SUBMENU DA LISTA ---");
                            Console.WriteLine("1. Adicionar elemento");
                            Console.WriteLine("2. Remover elemento");
                            Console.WriteLine("3. Mostrar lista");
                            Console.WriteLine("4. Voltar ao Menu Principal");
                            Console.Write("Escolha: ");
                            
                            while(!int.TryParse(Console.ReadLine(), out opcaoLista)); 

                            switch (opcaoLista) {
                                case 1:
                                    Console.Write("Digite o valor a ser adicionado: ");
                                    int valor = int.Parse(Console.ReadLine());
                                    minhaLista.push(valor);
                                    Console.WriteLine($"Valor {valor} adicionado!");
                                    break;
                                case 2:
                                    minhaLista.pop();
                                    Console.WriteLine("Último valor removido!");
                                    break;
                                case 3:
                                    Console.Write("Valores na lista: ");
                                    minhaLista.print();
                                    break;
                                case 4:
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
