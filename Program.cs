//Integrante 3
int[] precios = new int[10];
int[] cantidades = new int[10];
string[] productos = new string[10];

int totalProductos = 0;
int opcion = 0;
bool salir = false;


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