using System;

class Carro
{
    public string Marca;
    public string Modelo;
    public int Ano;

    public void ExibirDados()
    {
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano);
    }
}

class Funcionario
{
    public string Nome;
    public double Salario;
    public string Cargo;

    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Cargo: " + Cargo);
        Console.WriteLine("Salário: " + Salario);
    }

    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }

    public void AumentarSalario(double percentual)
    {
        Salario = Salario + (Salario * percentual / 100);
    }

    public void DescontarSalario(double valor)
    {
        Salario = Salario - valor;
    }
}

class Exercicios
{
    static int Soma(int a, int b)
    {
        return a + b;
    }

    static bool EhPar(int n)
    {
        return n % 2 == 0;
    }

    static int Maior(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        return b;
    }

    static double Media(double a, double b, double c)
    {
        return (a + b + c) / 3;
    }

    static void Main()
    {
        Console.WriteLine("===== Exercício 1 =====");
        Console.WriteLine("João Silva");
        Console.WriteLine("20");

        Console.WriteLine("\n===== Exercício 2 =====");
        Console.Write("Digite um número: ");
        int numEx2 = int.Parse(Console.ReadLine());
        Console.WriteLine(numEx2 * 2);

        Console.WriteLine("\n===== Exercício 3 =====");
        Console.Write("Primeiro número: ");
        double a3 = double.Parse(Console.ReadLine());
        Console.Write("Segundo número: ");
        double b3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Soma: " + (a3 + b3));
        Console.WriteLine("Subtração: " + (a3 - b3));
        Console.WriteLine("Multiplicação: " + (a3 * b3));
        Console.WriteLine("Divisão: " + (a3 / b3));

        Console.WriteLine("\n===== Exercício 4 =====");
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        if (idade >= 18)
        {
            Console.WriteLine("Maior de idade");
        }
        else
        {
            Console.WriteLine("Menor de idade");
        }

        Console.WriteLine("\n===== Exercício 5 =====");
        Console.Write("Digite um número: ");
        double num5 = double.Parse(Console.ReadLine());
        if (num5 > 0)
        {
            Console.WriteLine("Positivo");
        }
        else if (num5 < 0)
        {
            Console.WriteLine("Negativo");
        }
        else
        {
            Console.WriteLine("Zero");
        }

        Console.WriteLine("\n===== Exercício 6 =====");
        Console.Write("Digite um número para a tabuada: ");
        int num6 = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num6 + " x " + i + " = " + (num6 * i));
        }

        Console.WriteLine("\n===== Exercício 7 =====");
        double soma7 = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Digite o número " + i + ": ");
            soma7 = soma7 + double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Soma: " + soma7);
        Console.WriteLine("Média: " + (soma7 / 5));

        Console.WriteLine("\n===== Exercício 8 =====");
        double soma8 = 0;
        double num8 = -1;
        while (num8 != 0)
        {
            Console.Write("Digite um número (0 para sair): ");
            num8 = double.Parse(Console.ReadLine());
            soma8 = soma8 + num8;
        }
        Console.WriteLine("Soma: " + soma8);

        Console.WriteLine("\n===== Exercícios 9 a 12 (Métodos) =====");
        Console.WriteLine("Soma(3, 4): " + Soma(3, 4));
        Console.WriteLine("EhPar(6): " + EhPar(6));
        Console.WriteLine("EhPar(7): " + EhPar(7));
        Console.WriteLine("Maior(10, 20): " + Maior(10, 20));
        Console.WriteLine("Media(7, 8, 9): " + Media(7, 8, 9));

        Console.WriteLine("\n===== Exercícios 13 e 14 (Classe Carro) =====");
        Carro carro = new Carro();
        Console.Write("Marca: ");
        carro.Marca = Console.ReadLine();
        Console.Write("Modelo: ");
        carro.Modelo = Console.ReadLine();
        Console.Write("Ano: ");
        carro.Ano = int.Parse(Console.ReadLine());
        carro.ExibirDados();

        Console.WriteLine("\n===== Exercícios 15 a 17 (Classe Funcionario) =====");
        Funcionario funcionario = new Funcionario();
        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();
        Console.Write("Cargo: ");
        funcionario.Cargo = Console.ReadLine();
        Console.Write("Salário: ");
        funcionario.Salario = double.Parse(Console.ReadLine());
        funcionario.ExibirDados();
        Console.WriteLine("Salário anual: " + funcionario.CalcularSalarioAnual());
        funcionario.AumentarSalario(10);
        Console.WriteLine("Após aumento de 10%: " + funcionario.Salario);
        funcionario.DescontarSalario(100);
        Console.WriteLine("Após desconto de R$100: " + funcionario.Salario);

        Console.WriteLine("\n===== Exercícios 18 a 20 (Array de inteiros) =====");
        int[] numeros = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite o número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Valores digitados:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(numeros[i]);
        }
        int maior = numeros[0];
        for (int i = 1; i < 5; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }
        Console.WriteLine("Maior valor: " + maior);
        double soma20 = 0;
        for (int i = 0; i < 5; i++)
        {
            soma20 = soma20 + numeros[i];
        }
        Console.WriteLine("Média: " + (soma20 / 5));

        Console.WriteLine("\n===== Exercícios 22 a 25 (Array de objetos Carro) =====");
        Carro[] carros = new Carro[3];
        for (int i = 0; i < 3; i++)
        {
            carros[i] = new Carro();
            Console.Write("Marca do carro " + (i + 1) + ": ");
            carros[i].Marca = Console.ReadLine();
            Console.Write("Modelo do carro " + (i + 1) + ": ");
            carros[i].Modelo = Console.ReadLine();
            Console.Write("Ano do carro " + (i + 1) + ": ");
            carros[i].Ano = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Todos os carros:");
        for (int i = 0; i < 3; i++)
        {
            carros[i].ExibirDados();
        }
        double somaAnos = 0;
        for (int i = 0; i < 3; i++)
        {
            somaAnos = somaAnos + carros[i].Ano;
        }
        Console.WriteLine("Média dos anos: " + (somaAnos / 3));
        Console.Write("Digite o índice do carro que quer ver (0, 1 ou 2): ");
        int indice = int.Parse(Console.ReadLine());
        carros[indice].ExibirDados();
    }
}


// apenas para commitar denovo