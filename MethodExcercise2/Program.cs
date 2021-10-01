using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodExcercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise2();
        

        
                static int Add(int x, int y)
                {
                    return x + y;
                }

                static int Subtraction(int x, int y)
                {
                    return x - y;
                }

                static int Multiplication(int x, int y)
                {
                    return x * y;
                }

                static int Division(int x, int y)
                {
                    return x / y;
                }

                static int Remainder(int x, int y)
                {
                    return x % y;
                }
            
            
                 static void Exercise2()
                {
                    Console.WriteLine("Enter the sum :");
                    int sum = Add(3, 4);
                    Console.WriteLine(sum);

                    Console.WriteLine();

                    Console.WriteLine("Enter the value of subtract : ");
                    int subtract = Subtraction(3, 4);
                    Console.WriteLine(subtract);

                    Console.WriteLine();

                    Console.WriteLine("enter the value of multiply :");
                    int multiply = Multiplication(3, 4);
                    Console.WriteLine(multiply);

                    Console.WriteLine();

                    Console.WriteLine("enter the value of division :");
                    int quotient = Division(3, 4);
                    Console.WriteLine(quotient);

                    Console.WriteLine();

                    Console.WriteLine("enter the remainder value :");
                    int modulus = Remainder(3, 4);
                    Console.WriteLine(modulus);
                }
            


        }
    }
}
