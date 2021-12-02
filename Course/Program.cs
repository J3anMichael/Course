using System;

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
        }
    }
}

