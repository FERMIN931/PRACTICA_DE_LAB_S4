using System;
class Program
{
    static int contador = 0; // variable global

    static void Incrementar()
    {
        int local = 5; // variable local
        contador += local;
        Console.WriteLine($"Contador actual: {contador}");
    }

    static void Main()
    {
        Incrementar();
        Incrementar();
        Incrementar();
    }
}
