using System;
using System.Globalization; // imprimir dados globais

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false; //variavel booleana(true/false)
            char gender = 'F';     //variavel de um unico caractere
            char letra = '\u004A'; //caractere unicode
            byte n1 = 255;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.6;
            string nome = "Jean Michael";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            int menorValor = int.MinValue; // menor valor
            int maiorValor = int.MaxValue; // maior valor
            double saldo = 8.7895;
            int idade = 24;



            Console.Write(nome); // vai escrever na mesma linha
            Console.WriteLine(" e "); // vai escrever na mesma linha
            Console.Write(obj1); // vai escrever na mesma linha
            Console.WriteLine(gender);
            Console.WriteLine(completo);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(menorValor);
            Console.WriteLine(maiorValor);
            Console.WriteLine(saldo.ToString("F2")); // vai imprimir com duas casas decimais
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture)); // vai imprimir com o " . " como separador decimal 


            // SAIDA DE DADOS

            // Placeholder Ex:
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));

            // Interpolacao
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            // Concatenacao
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");




            // EXERCICIO DE FIXACAO

            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte age = 24;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preco e $" + preco1);
            Console.WriteLine(produto2 + ", cujo preco e $" + preco2);

            Console.WriteLine("Registro: " + idade + " anos, codigo " + codigo + " e genero: " + genero);

            Console.WriteLine("Medida com oito casas decimais: " + medida);
            Console.WriteLine("Arredondado: " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));


            Console.WriteLine("--------------------------------------------");

            // OPERADORES DE ATRIBUICAO

            int a = 10;
            a += 2;
            Console.WriteLine(a);

            int b = 50;
            b -= 15;
            Console.WriteLine(b);

            int c = 30;
            c *= 2;
            Console.WriteLine(c);


            string f = "ABC";
            f += "DEF";
            Console.WriteLine(f);

            Console.WriteLine("-------------------------------");

            // OPERADORES ARITMETICOS / ATRIBUICAO

            // ++ (incrementar valor)

            int valor = 10;
            valor++;
            Console.WriteLine(valor);

            int valor2 = 50;
            valor2--;
            Console.WriteLine(valor2);


            Console.WriteLine("-------------------------------");

            // CONVERSAO IMPLICITA E CASTING



            // CASTING

            int val1 = 5;
            int val2 = 2;

            double resultado = (double) val1 / val2;

            Console.WriteLine(resultado);


        }
    }
}


