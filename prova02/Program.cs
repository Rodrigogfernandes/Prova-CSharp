using System;

namespace prova02 {
    class Program {
        static void Main(string[] args) {
            int opcao;
            do {
                Console.WriteLine(@"
                
                +-------------------------------------------------+
                |       Prova 02 - Lógica de Programação          |
                +-------------------------------------------------+
                |  0 Para parar o programa                        |
                |  1 Para Contagem Inteligente                    |
                |  2 Para Média com Validação                     |
                |  3 Para Sistema de Acesso Avançado              |
                |  4 Para Controle de Estoque                     |
                |  5 Para Análise de Lista com Interrupção        |
                |  6 Para Desafio Final (Raciocínio)              |
                +-------------------------------------------------+
");
                Console.Write("                Digite o numero de uma das opções acima: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.Clear();

                string continuar = null;
                switch (opcao) {
                    case 1:
                        while (continuar != "n") {
                            Console.WriteLine("************* Contagem Inteligente ***************\n\n\n\n\n");
                            Console.Write("digite um numero: ");
                            int N = int.Parse(Console.ReadLine());
                            int par = 0;
                            int impar = 0;

                            for (int i = 1; i <= N; i++) {
                                if (i % 2 == 0) {
                                Console.WriteLine("Par: "+ i);
                                    par++;
                                }
                                else {
                                    Console.WriteLine("Impar: " + i);
                                    impar++;
                                }
                            }

                            Console.WriteLine($"Total de numeros pares: {par}");
                            Console.WriteLine($"Total de numeros impares: {impar}");

                            Console.WriteLine("deseja repetir digite 's', se quiser sair digite 'n'.");
                            continuar = Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        while (continuar != "n") {
                        Console.WriteLine("************* Media Com Validacao ***************\n\n\n\n\n");

                            int[] notas = new int[8];
                            int nota = 0;
                            int media;
                            for (int i = 0; i < notas.Length; i++) {
                                Console.Write($"Digite a {i + 1}ª nota : ");

                                while (!int.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10) {
                                    Console.Write($"A {i + 1}ª nota deve ser entre 0 e 10: ");
                                    
                                }
                                notas[i] = nota;
                                

                            }





                            Console.WriteLine("deseja repetir digite 's', se quiser sair digite 'n'.");
                            continuar = Console.ReadLine();
                            Console.Clear();

                        }
                        Console.WriteLine("Media Com Validacao");

                        break;
                    case 3:
                        Console.WriteLine("Sistema De Acesso Avancado");
                        break;
                    case 4:
                        Console.WriteLine("Controle De Estoque");
                        break;
                    case 5:
                        Console.WriteLine("Analise De Lista Com Interrupcao");
                        break;
                    case 6:
                        Console.WriteLine("Desafio Final Raciocinio");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                
                Console.Clear();

            } while (opcao != 0);
        }
    }
}