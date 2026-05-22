//Integrante 1
int[] precios = new int[10];
int[] cantidades = new int[10];
string[] productos = new string[10];

int totalProductos = 0;
int opcion = 0;
bool salir = false;

do
{
    Console.Clear();
    Console.WriteLine("===== MENÚ =====");
    Console.WriteLine("1. Registrar productos");
    Console.WriteLine("2. Mostrar productos");
    Console.WriteLine("3. Calcular total vendido");
    Console.WriteLine("4. Mostrar producto más vendido");
    Console.WriteLine("5. Mostrar promedio de ventas");
    Console.WriteLine("6. Salir");
    Console.Write("Seleccione una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Error: ingrese una opción numérica.");
        Console.ReadKey();
        continue;
    }

    switch (opcion)
    {
        case 1:
            RegistrarProductos();
            break;

        case 2:
            MostrarProductos();
            break;

        case 3:
            MostrarTotalVendido();
            break;

        case 4:
            MostrarProductoMasVendido();
            break;

        case 5:
            MostrarPromedioVentas();
            break;

        case 6:
            salir = true;
            Console.WriteLine("Saliendo del sistema...");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

    if (!salir)
    {
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }

} while (!salir);