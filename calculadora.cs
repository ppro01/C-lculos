using System;
class Program
{
    static void Main(string[] args)
    {
        int firstNmbr, secondNmbr;
        char Option;
        Console.WriteLine("digite o primeiro numero");
        firstNmbr = int.Parse(Console.ReadLine());
        Console.WriteLine("digite o segundo  numero");
        secondNmbr = int.Parse(Console.ReadLine());
        Console.WriteLine("digite uma opçao ");
        Console.WriteLine("1-soma \n2-subtração \n3-multiplicação \n4-cubo \n5-divisão \n6-Resto da divisão \n7-Raiz quadrada \n8-dobro \n 9-Quadrado");
        opc = char.Parse(Console.ReadLine());

        switch (Option)
        {

            case '1':
                    string x = som(firstNmbr, secondNmbr);
                Console.WriteLine(x);
                break;
            case '2':
                sub(firstNmbr, secondNmbr);
                break;
            case '3':
                  mult(firstNmbr, secondNmbr);
                break;
            case '4': cubo(firstNumber);
                break;
            case '5': x = div(firstNmbr, secondNmbr);
                Console.WriteLine(x);
                break;
            case '6':  restdiv(firstNmbr, secondNmbr);
                break;
            case '7': x = raizquadrada(firstNmbr);
                Console.WriteLine(x);
                break;
            case '8':
                dob(firstNmbr);
                break;
            case '9':
                x = quadrado(firstNmbr);
                Console.WriteLine(x);
                break;

        }
        Console.ReadKey();
    }
    static void sub(int n1, int n2)
    {
        int res = n1 - n2;
        Console.WriteLine("o resultado é {0}", res);
    }
    static string som(int n1, int n2)
    {
        int res = n1 + n2;
        return "o resultado é " + res;
    }
    static void mult(int n1, int n2)
    {
        int res = n1 * n2;
        Console.WriteLine("o resultado é {0}", res);
    }
    static void cubo(double n1) {
        double res = Math.Pow(n1, 3);
        Console.WriteLine("o resultado é {0}", res);
    }
    static string div(double n1, double n2)
    {
        double res = n1 / n2;
        return "o resultado é " + res;
    }
    static void restdiv(double n1, double n2)
    {
        double res = n1 % n2;
        Console.WriteLine("o resultado é {0}", res);
    }

     static string raizquadrada(double n1)
    {
        double res = Math.Sqrt(n1);
        return "o resultado é " + res;
    }
    static void dob(int n1)
    {
        int res = n1 * 2;
        Console.WriteLine("o resultado é {0}", res);
    }
    static string quadrado(int n1) { 
        int res = n1 * n1;
        return "o resultado é " + res;
        }
}