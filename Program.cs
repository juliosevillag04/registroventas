//Integrante 1 - Diseño de datos y menú principal
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

    if (salir == false)
    {
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }

} while (salir == false);

//Integrante 2 - Entrada de datos y validaciones
int RegistrarProductos()
{
    if (totalProductos >= productos.Length)
    {
        Console.WriteLine("Ya se registraron los 10 productos.");
        return 0;
    }

    Console.WriteLine("===== REGISTRAR PRODUCTO =====");

    string nombre = "";

    do
    {
        Console.Write("Nombre del producto: ");
        nombre = Console.ReadLine()!;

        if (nombre == "")
        {
            Console.WriteLine("Error: el nombre no puede estar vacío.");
        }

    } while (nombre == "");

    int precio = 0;

    do
    {
        Console.Write("Precio del producto: ");

        if (!int.TryParse(Console.ReadLine(), out precio))
        {
            Console.WriteLine("Error: ingrese solo números enteros.");
            precio = -1;
        }
        else if (precio <= 0)
        {
            Console.WriteLine("Error: el precio debe ser mayor que 0.");
        }

    } while (precio <= 0);

    int cantidad = 0;

    do
    {
        Console.Write("Cantidad vendida: ");

        if (!int.TryParse(Console.ReadLine(), out cantidad))
        {
            Console.WriteLine("Error: ingrese solo números enteros.");
            cantidad = -1;
        }
        else if (cantidad < 0)
        {
            Console.WriteLine("Error: la cantidad no puede ser negativa.");
        }

    } while (cantidad < 0);

    productos[totalProductos] = nombre;
    precios[totalProductos] = precio;
    cantidades[totalProductos] = cantidad;

    totalProductos++;

    Console.WriteLine("Producto registrado correctamente.");

    return 0;
}

//Integrante 3 - Procesamiento de datos
int ObtenerTotalVendido()
{
    int totalVendido = 0;

    for (int i = 0; i < totalProductos; i++)
    {
        totalVendido += precios[i] * cantidades[i];
    }

    return totalVendido;
}

int MostrarTotalVendido()
{
    if (totalProductos == 0)
    {
        Console.WriteLine("No hay productos registrados.");
        return 0;
    }

    int totalVendido = ObtenerTotalVendido();

    Console.WriteLine("===== TOTAL VENDIDO =====");
    Console.WriteLine("Total acumulado: C$ " + totalVendido);

    return 0;
}

//Integrante 4 - Salida, reportes y pruebas
int MostrarProductos()
{
    if (totalProductos == 0)
    {
        Console.WriteLine("No hay productos registrados.");
        return 0;
    }

    Console.WriteLine("===== PRODUCTOS REGISTRADOS =====");
    Console.WriteLine("{0,-15} {1,10} {2,10}", "Producto", "Precio", "Cantidad");
    Console.WriteLine(new string('-', 40));

    for (int i = 0; i < totalProductos; i++)
    {
        Console.WriteLine("{0,-15} C${1,9} {2,10}",
            productos[i],
            precios[i],
            cantidades[i]);
    }

    return 0;
}

int MostrarProductoMasVendido()
{
    if (totalProductos == 0)
    {
        Console.WriteLine("No hay productos registrados.");
        return 0;
    }

    int posicionMayor = 0;

    for (int i = 1; i < totalProductos; i++)
    {
        if (cantidades[i] > cantidades[posicionMayor])
        {
            posicionMayor = i;
        }
    }

    Console.WriteLine("===== PRODUCTO MÁS VENDIDO =====");
    Console.WriteLine("Producto: " + productos[posicionMayor]);
    Console.WriteLine("Cantidad vendida: " + cantidades[posicionMayor]);

    return 0;
}

int MostrarPromedioVentas()
{
    if (totalProductos == 0)
    {
        Console.WriteLine("No hay productos registrados.");
        return 0;
    }

    int totalVendido = ObtenerTotalVendido();
    double promedio = (double)totalVendido / totalProductos;

    Console.WriteLine("===== PROMEDIO DE VENTAS =====");
    Console.WriteLine("Total vendido: C$ " + totalVendido);
    Console.WriteLine("Productos registrados: " + totalProductos);
    Console.WriteLine("Promedio de ventas: C$ " + promedio.ToString("F2"));

    return 0;
}