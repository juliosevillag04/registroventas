//Integrante 2

int[] precios = new int[10];
int[] cantidades = new int[10];
string[] productos = new string[10];

int totalProductos = 0;
int opcion = 0;
bool salir = false;



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