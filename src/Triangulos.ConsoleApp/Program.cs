namespace Triangulos.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Insira o valor do primeiro lado do triângulo");
            triangulo.lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do segundo lado do triângulo");
            triangulo.lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do terceiro lado do triângulo");
            triangulo.lado3 = int.Parse(Console.ReadLine());

            triangulo.CalcularTriangulo();

            Console.ReadKey();
        }
    }
}