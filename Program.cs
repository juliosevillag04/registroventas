//tarea2

using System;

string[] nombres = new string[10];
double[] precios = new double[10];
int[] cantidades = new int[10];

int totalProductos = 0;
int opcion;

do
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("===== MENU =====");
    Console.ResetColor();

    Console.WriteLine("1. Registrar productos");
    Console.WriteLine("2. Mostrar productos");
    Console.WriteLine("3. Salir");
    Console.Write("\nSeleccione una opción: ");

    int.TryParse(Console.ReadLine(), out opcion);

    switch (opcion)
    {
        case 1:

            for (int i = totalProductos; i < 10; i++)
            {
                Console.Clear();

                Console.WriteLine($"Producto #{i + 1}");

                // NOMBRE
                string nombre;

                do
                {
                    Console.Write("Ingrese el nombre del producto: ");
                    nombre = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("El nombre no puede estar vacío.");
                        Console.ResetColor();
                    }

                } while (string.IsNullOrWhiteSpace(nombre));

                nombres[i] = nombre;

                // PRECIO
                double precio;

                do
                {
                    Console.Write("Ingrese el precio del producto: ");

                    if (!double.TryParse(Console.ReadLine(), out precio) || precio < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ingrese un precio válido.");
                        Console.ResetColor();

                        precio = -1;
                    }

                } while (precio < 0);

                precios[i] = precio;

                // CANTIDAD
                int cantidad;

                do
                {
                    Console.Write("Ingrese la cantidad del producto: ");

                    if (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ingrese una cantidad válida.");
                        Console.ResetColor();

                        cantidad = -1;
                    }

                } while (cantidad < 0);

                cantidades[i] = cantidad;

                totalProductos++;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nProducto registrado correctamente.");
                Console.ResetColor();

                Console.Write("\n¿Desea registrar otro producto? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "s")
                {
                    break;
                }
            }

            break;

        case 2:

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===== PRODUCTOS =====");
            Console.ResetColor();

            if (totalProductos == 0)
            {
                Console.WriteLine("No hay productos registrados.");
            }
            else
            {
                for (int i = 0; i < totalProductos; i++)
                {
                    Console.WriteLine(
                        $"{i + 1}. {nombres[i]} | Precio: {precios[i]} | Cantidad: {cantidades[i]}"
                    );
                }
            }

            Console.WriteLine("\nPresione una tecla para volver...");
            Console.ReadKey();

            break;

        case 3:

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saliendo del sistema...");
            Console.ResetColor();

            break;

        default:

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opción inválida.");
            Console.ResetColor();

            Console.ReadKey();

            break;
    }

} while (opcion != 3);