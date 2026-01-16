using System;
using System.Net.WebSockets;
using System.Xml;

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
                                    Console.WriteLine("Par: " + i);
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
                            int nota;
                            int soma = 0;
                            int media;
                            int numValidos = 0;
                            int nunDescartados = 0;
                            for (int i = 0; i < notas.Length; i++) {
                                Console.Write($"\rDigite a {i + 1}ª nota : ");

                                while (!int.TryParse(Console.ReadLine(), out nota)) {
                                    Console.Write($"A {i + 1}ª nota deve ser entre 0 e 10: ");

                                }

                                if (nota >= 0 && nota <= 10) {
                                    notas[i] = nota;
                                    soma += nota;
                                    numValidos++;

                                }
                                else {
                                    nunDescartados++;

                                }

                            }
                            if (numValidos > 0) {
                                media = soma / numValidos;

                            }
                            else {
                                media = 0;
                            }

                            Console.WriteLine("Notas digitadas:");
                            Console.WriteLine(string.Join(", ", notas));
                            Console.WriteLine("\nNumeros validos: " + numValidos);
                            Console.WriteLine("Numeros descartados: " + nunDescartados);
                            Console.WriteLine("Média das notas válidas: " + media);

                            Console.WriteLine("\n\n\n\n\ndeseja repetir digite 's', se quiser sair digite 'n'.");
                            continuar = Console.ReadLine();
                            Console.Clear();

                        }


                        break;
                    case 3:
                        while (continuar != "n") {

                            int contador = 0;
                            int maxTentativas = 3;
                            string usuarioCorreto = "admin";
                            string senhaCorreta = "2025";
                            string usuario;
                            string senha;

                            Console.WriteLine("                             ************* Sistema De Acesso Avancado ***************\n\n\n\n\n");
                            while (contador < maxTentativas) {

                                Console.Write(@$"                                                 {contador + 1}ª Tentativa.
                                                 Digite o usuário: ");
                                usuario = Console.ReadLine();
                                Console.Write(@"                                                 Digite a senha: ");
                                senha = Console.ReadLine();

                                if (usuario == usuarioCorreto && senha == senhaCorreta) {
                                    Console.WriteLine("\n           Acesso concedido. Bem-vindo, admin!\n\n\n\n");
                                    contador = maxTentativas + 1;
                                }
                                else if (usuario != usuarioCorreto && senha == senhaCorreta) {
                                    Console.WriteLine($"         Acesso negado. Usuário incorreto. Tentativa {contador + 1}/{maxTentativas}.\n");
                                    contador++;
                                }
                                else if (usuario == usuarioCorreto && senha != senhaCorreta) {
                                    Console.WriteLine($"         Acesso negado. Senha incorreta.Tentativa {contador + 1}/{maxTentativas}.\n");
                                    contador++;
                                }
                                else if (usuario != usuarioCorreto && senha != senhaCorreta) {
                                    Console.WriteLine($"         Acesso negado. Usuário e senha incorretos. Tentativa {contador + 1}/{maxTentativas}.\n");
                                    contador++;
                                }

                            }
                            if (contador == maxTentativas) {
                                Console.WriteLine("         Número máximo de tentativas excedido. Acesso bloqueado.\n\n\n\n");
                            }


                            Console.WriteLine("\n\n\n\n\n                       deseja repetir digite 's', se quiser sair digite 'n'.");
                            continuar = Console.ReadLine();
                            Console.Clear();

                        }
                        break;
                    case 4:
                        while (continuar != "n") {
                            Console.WriteLine("************* Controle De Estoque ***************\n\n\n");
                            int[] codigos = new int[200];
                            int contador = 0;
                            int[] itemEspecial = new int[200];
                            int soma = 0;

                            for (int i = 0; i < codigos.Length; i++) {

                                codigos[i] = i + 1;

                                if (codigos[i] % 2 == 0 && codigos[i] % 4 == 0) {
                                    if (i != 0) {
                                        itemEspecial[contador] = codigos[i];
                                        contador++;
                                    }
                                }
                                
                                
                            }

                            Console.WriteLine("todos os codigos\n");
                            Console.Write(string.Join(", ", codigos));
                            Console.WriteLine($"\n\nTotal de itens no estoque: {codigos.Length}");

                            Console.WriteLine("\n\nitens especiais\n");
                            for (int i = 0; i < contador ; i++) {
                                Console.Write(itemEspecial[i] + " ");
                            }
                            Console.WriteLine($"\n\n Total de itens especiais no estoque: {contador}");

                            for (int i = 0; i < contador; i++) {
                               soma += itemEspecial[i];
                            }
                            Console.WriteLine($" Soma dos codigos especiais: {soma}");

                            Console.WriteLine("\n\n\ndeseja repetir digite 's', se quiser sair digite 'n'.");
                            continuar = Console.ReadLine();
                            Console.Clear();
                        }
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