
---

# 📘 Prova – Lógica de Programação (Versão 2)

---

## 🔹 Questão 1 – Contagem Inteligente

Crie um algoritmo que leia um número inteiro **N** e exiba:

* Todos os números de **1 até N**
* Ao final, mostre:

  * Quantos números são **pares**
  * Quantos números são **ímpares**

---

## 🔹 Questão 2 – Média com Validação

Crie um algoritmo que solicite ao usuário a entrada de **8 números inteiros positivos**.

* Caso o usuário digite um número **negativo**, ele não deve ser considerado.
* Ao final, exiba:

  * A **média** dos números válidos
  * A quantidade de números descartados

---

## 🔹 Questão 3 – Sistema de Acesso Avançado

Você foi contratado para criar um sistema de login.

Dados:

* Usuário padrão: `admin`
* Senha padrão: `2025`

Regras:

* O usuário tem **3 tentativas**
* Se errar a senha:

  * Exiba quantas tentativas ainda restam
* Se acertar:

  * Exiba: `"Acesso permitido. Sistema liberado."`
* Se errar todas:

  * Exiba: `"Sistema bloqueado por segurança."`

---

## 🔹 Questão 4 – Controle de Estoque (Laço + Condição)

Uma empresa deseja analisar seus produtos cadastrados por código numérico.

Regras:

* Os códigos vão de **1 até 200**
* Um produto é considerado **especial** se:

  * For **par**
  * E **divisível por 4**
* O algoritmo deve:

  * Exibir todos os códigos especiais
  * Somar o valor total desses códigos
  * Mostrar o total ao final

---

## 🔹 Questão 5 – Análise de Lista com Interrupção

Crie um algoritmo que percorra uma lista de números inteiros e faça as seguintes análises:

* Encontre o **menor número par**
* Some todos os **números ímpares**
* Se durante a leitura encontrar o número **-1**, o algoritmo deve parar imediatamente

Ao final, exiba:

* `"Fim da análise"`
* O menor número par encontrado
* A soma dos números ímpares

Lista:

```
14, 9, 22, 17, 6, 31, 18, 5, 27, 40, 12, 3, -1, 50, 21
```

---

## 🔹 Questão 6 – Desafio Final (Raciocínio)

Crie um algoritmo que simule um caixa eletrônico:

* O saldo inicial é **R$ 1.000**
* O usuário pode:

  1. Consultar saldo
  2. Sacar valor
  3. Depositar valor
  4. Sair
* O sistema deve continuar exibindo o menu até o usuário escolher sair
* Não permitir saque maior que o saldo disponível

---

### ✅ Conteúdos avaliados

* Estruturas de repetição (`for`, `while`, `foreach`)
* Condições (`if`, `else`)
* Operadores matemáticos e lógicos
* Interrupção de laço (`break`)
* Validação de dados
* Lógica aplicada a problemas reais
</br>
</br>
</br>
</br>
</br>
</br>
</br>
</br>
</br>
</br>

## **GABARITO COMPLETO em C#** da **Prova – Lógica de Programação** ✅

---

## 🟢 Questão 1 – Contagem Inteligente

```csharp
int N = int.Parse(Console.ReadLine());
int pares = 0, impares = 0;

for (int i = 1; i <= N; i++)
{
    Console.WriteLine(i);

    if (i % 2 == 0)
        pares++;
    else
        impares++;
}

Console.WriteLine($"Quantidade de pares: {pares}");
Console.WriteLine($"Quantidade de ímpares: {impares}");
```

---

## 🟢 Questão 2 – Média com Validação

```csharp
int soma = 0;
int contador = 0;
int descartados = 0;

for (int i = 1; i <= 8; i++)
{
    int numero = int.Parse(Console.ReadLine());

    if (numero >= 0)
    {
        soma += numero;
        contador++;
    }
    else
    {
        descartados++;
    }
}

if (contador > 0)
{
    double media = (double)soma / contador;
    Console.WriteLine($"Média dos números válidos: {media}");
}
else
{
    Console.WriteLine("Nenhum número válido informado.");
}

Console.WriteLine($"Números descartados: {descartados}");
```

---

## 🟢 Questão 3 – Sistema de Acesso Avançado

```csharp
string usuarioCorreto = "admin";
string senhaCorreta = "2025";
int tentativas = 3;

while (tentativas > 0)
{
    Console.Write("Usuário: ");
    string usuario = Console.ReadLine();

    Console.Write("Senha: ");
    string senha = Console.ReadLine();

    if (usuario == usuarioCorreto && senha == senhaCorreta)
    {
        Console.WriteLine("Acesso permitido. Sistema liberado.");
        break;
    }
    else
    {
        tentativas--;
        if (tentativas > 0)
            Console.WriteLine($"Dados incorretos. Tentativas restantes: {tentativas}");
        else
            Console.WriteLine("Sistema bloqueado por segurança.");
    }
}
```

---

## 🟢 Questão 4 – Controle de Estoque

```csharp
int soma = 0;

for (int codigo = 1; codigo <= 200; codigo++)
{
    if (codigo % 2 == 0 && codigo % 4 == 0)
    {
        Console.WriteLine($"Código especial: {codigo}");
        soma += codigo;
    }
}

Console.WriteLine($"Soma total dos códigos especiais: {soma}");
```

---

## 🟢 Questão 5 – Análise de Lista com Interrupção

```csharp
int[] numeros = { 14, 9, 22, 17, 6, 31, 18, 5, 27, 40, 12, 3, -1, 50, 21 };

int menorPar = int.MaxValue;
int somaImpares = 0;

foreach (int numero in numeros)
{
    if (numero == -1)
        break;

    if (numero % 2 == 0)
    {
        if (numero < menorPar)
            menorPar = numero;
    }
    else
    {
        somaImpares += numero;
    }
}

Console.WriteLine("Fim da análise");

if (menorPar != int.MaxValue)
    Console.WriteLine($"Menor número par: {menorPar}");
else
    Console.WriteLine("Nenhum número par encontrado.");

Console.WriteLine($"Soma dos números ímpares: {somaImpares}");
```

---

## 🟢 Questão 6 – Desafio Final (Caixa Eletrônico)

```csharp
double saldo = 1000;
int opcao;

do
{
    Console.WriteLine("\n1 - Consultar saldo");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Depositar");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Saldo atual: R$ {saldo}");
            break;

        case 2:
            Console.Write("Valor para saque: ");
            double saque = double.Parse(Console.ReadLine());

            if (saque <= saldo && saque > 0)
            {
                saldo -= saque;
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido.");
            }
            break;

        case 3:
            Console.Write("Valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());

            if (deposito > 0)
            {
                saldo += deposito;
                Console.WriteLine("Depósito realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
            break;

        case 4:
            Console.WriteLine("Encerrando sistema...");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

} while (opcao != 4);
```

---
