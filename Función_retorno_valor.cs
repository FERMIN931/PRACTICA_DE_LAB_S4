using System;
class Program
{
    static double CalcularArea(double baseR, double altura)
    {
        return baseR * altura;
    }

    static void Main()
    {
        Console.Write("Ingrese la base: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la altura: ");
        double h = double.Parse(Console.ReadLine());

        double area = CalcularArea(b, h);
        Console.WriteLine($"El área del rectángulo es: {area}");
    }
}
