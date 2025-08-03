using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Calcular el área de un terreno rectangular
        Console.WriteLine("1. Cálculo del área de un terreno rectangular");
        Console.Write("Ingrese la base (m): ");
        double baseTerreno = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura (m): ");
        double alturaTerreno = Convert.ToDouble(Console.ReadLine());
        double area = baseTerreno * alturaTerreno;
        Console.WriteLine($"Área total: {area} m²\n");

        // 2. Calcular el promedio de tres notas
        Console.WriteLine("2. Promedio de tres calificaciones");
        Console.Write("Ingrese nota 1: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese nota 2: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese nota 3: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());
        double promedio = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"Promedio final: {promedio:F2}\n");

        // 3. Convertir temperatura de Celsius a Fahrenheit
        Console.WriteLine("3. Conversión de Celsius a Fahrenheit");
        Console.Write("Ingrese temperatura en °C: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Temperatura en °F: {fahrenheit:F2}\n");

        // 4. Convertir dólares a colones
        Console.WriteLine("4. Conversión de dólares a colones (Tasa: 8.75)");
        Console.Write("Ingrese cantidad en dólares: ");
        double dolares = Convert.ToDouble(Console.ReadLine());
        double colones = dolares * 8.75;
        Console.WriteLine($"Equivalente en colones: ₡{colones:F2}\n");

        // 5. Calcular meses y días vividos
        Console.WriteLine("5. Calcular meses y días vividos");
        Console.Write("Ingrese su edad en años: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        int mesesVividos = edad * 12;
        int diasVividos = edad * 365; // sin considerar años bisiestos
        Console.WriteLine($"Ha vivido aproximadamente {mesesVividos} meses y {diasVividos} días\n");

        // 6. Calcular perímetro de un triángulo
        Console.WriteLine("6. Perímetro de un triángulo");
        Console.Write("Ingrese lado A: ");
        double ladoA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese lado B: ");
        double ladoB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese lado C: ");
        double ladoC = Convert.ToDouble(Console.ReadLine());
        double perimetro = ladoA + ladoB + ladoC;
        Console.WriteLine($"Perímetro total: {perimetro}\n");

        // 7. Cuadrado y raíz cuadrada de un número
        Console.WriteLine("7. Cuadrado y raíz cuadrada de un número");
        Console.Write("Ingrese un número: ");
        double numero = Convert.ToDouble(Console.ReadLine());
        double cuadrado = Math.Pow(numero, 2);
        double raiz = Math.Sqrt(numero);
        Console.WriteLine($"Cuadrado: {cuadrado}");
        Console.WriteLine($"Raíz cuadrada: {raiz:F2}\n");

        Console.WriteLine("Programa finalizado. Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}

