using System;
class Program
{
    static double CalcularBono(double sueldo, int rendimiento)
    {
        if (rendimiento >= 90) return sueldo * 0.20;
        else if (rendimiento >= 75) return sueldo * 0.10;
        else return 0;
    }

    static void Main()
    {
        Console.Write("Ingrese el sueldo base: ");
        double sueldo = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el porcentaje de rendimiento: ");
        int rendimiento = int.Parse(Console.ReadLine());

        double bono = CalcularBono(sueldo, rendimiento);
        Console.WriteLine($"El bono es: {bono}");
        Console.WriteLine($"Sueldo total: {sueldo + bono}");
    }
}
