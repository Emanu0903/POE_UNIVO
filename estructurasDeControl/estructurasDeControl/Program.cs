using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("MENÚ PRINCIPAL");
            Console.WriteLine("1. Calculadora (Sumar, Restar, Salir)");
            Console.WriteLine("2. Sumar N números");
            Console.WriteLine("3. Verificar contraseña con 3 intentos");
            Console.WriteLine("4. Calcular promedio y rendimiento");
            Console.WriteLine("5. Sistema de inventario");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Calculadora();
                    break;
                case "2":
                    SumarNumeros();
                    break;
                case "3":
                    VerificarContrasena();
                    break;
                case "4":
                    CalcularPromedio();
                    break;
                case "5":
                    SistemaInventario();
                    break;
                case "6":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.\n");
                    break;
            }
        }

        Console.WriteLine("Programa finalizado.");
    }

    // 1. Calculadora con menú
    static void Calculadora()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n-- Calculadora --");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el primer número: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Resultado: {a + b}\n");
                    break;

                case "2":
                    Console.Write("Ingrese el primer número: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Resultado: {x - y}\n");
                    break;

                case "3":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción inválida.\n");
                    break;
            }
        }
    }

    // 2. Sumar N números con ciclo for
    static void SumarNumeros()
    {
        Console.Write("\n¿Cuántos números desea sumar?: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        double suma = 0;

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            suma += Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine($"Suma total: {suma}\n");
    }

    // 3. Verificar contraseña con 3 intentos
    static void VerificarContrasena()
    {
        string contrasenaCorrecta = "1234";
        int intentos = 0;
        bool acceso = false;

        while (intentos < 3 && !acceso)
        {
            Console.Write("Ingrese la contraseña: ");
            string input = Console.ReadLine();

            if (input == contrasenaCorrecta)
            {
                Console.WriteLine("Acceso permitido.\n");
                acceso = true;
            }
            else
            {
                intentos++;
                Console.WriteLine($"Contraseña incorrecta. Intento {intentos}/3\n");
            }
        }

        if (!acceso)
        {
            Console.WriteLine("Acceso denegado.\n");
        }
    }

    // 4. Calcular promedio de calificaciones y clasificar rendimiento
    static void CalcularPromedio()
    {
        Console.Write("\n¿Cuántas calificaciones desea ingresar?: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double suma = 0;
        int validas = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Ingrese calificación {i} (0-10): ");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 0 && nota <= 10)
            {
                suma += nota;
                validas++;
            }
            else
            {
                Console.WriteLine("Calificación inválida, no se suma.");
            }
        }

        if (validas > 0)
        {
            double promedio = suma / validas;
            Console.WriteLine($"Promedio: {promedio:F2}");

            if (promedio < 6)
                Console.WriteLine("Rendimiento: Bajo\n");
            else if (promedio <= 8)
                Console.WriteLine("Rendimiento: Regular\n");
            else
                Console.WriteLine("Rendimiento: Excelente\n");
        }
        else
        {
            Console.WriteLine("No se ingresaron calificaciones válidas.\n");
        }
    }

    // 5. Sistema de inventario
    static void SistemaInventario()
    {
        Console.Write("\n¿Cuántos productos desea ingresar?: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        double totalInventario = 0;

        for (int i = 1; i <= cantidad; i++)
        {
            Console.WriteLine($"\nProducto {i}:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Cantidad: ");
            int cantidadProd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Precio unitario: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            double subtotal = cantidadProd * precio;
            totalInventario += subtotal;

            Console.WriteLine($"Subtotal de {nombre}: {subtotal:C}");
        }

        Console.WriteLine($"\nTotal en inventario: {totalInventario:C}\n");
    }
}
