//Integrante 4
int[] precios = new int[10];
int[] cantidades = new int[10];
string[] productos = new string[10];

int totalProductos = 0;
int opcion = 0;
bool salir = false;

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