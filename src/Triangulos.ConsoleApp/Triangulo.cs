namespace Triangulos.ConsoleApp
{
    internal partial class Program
    {
        public class Triangulo
        {
            public int lado1;
            public int lado2;
            public int lado3;
            public void CalcularTriangulo()
            {
                if (lado1 + lado2 > lado3 && lado1 + lado3 > 2 && lado2 + lado3 > lado1)
                {
                    if (lado1 == lado2 && lado2 == lado3)
                    {
                        Console.WriteLine("Seu triângulo é equilátero");
                    }
                    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                    {
                        Console.WriteLine("Seu triângulo é isósceles");
                    }
                    else
                    {
                        Console.WriteLine("Seu triângulo é escaleno");
                    }
                }
                else
                {
                    Console.WriteLine("Triângulo inválido");
                }
            }
        }
    }
}