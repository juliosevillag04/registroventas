//tarea2
string[] nombres = new string[10];
double[] precios = new double[10];
int[] cantidades = new int[10];

int totalProductos = 0;
for(int i = 0; i < 10; i++)
try
{
    Console.WriteLine("Ingrese el nombre del producto:");
    string nombre = Console.ReadLine();
    if (string.IsNullOrEmpty(nombre))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        throw new Exception("El nombre del producto no puede estar vacío.");
        Console.ResetColor();
    }
    nombres[i] = nombre;

    Console.WriteLine("Ingrese el precio del producto:");
    double precio = Convert.ToDouble(Console.ReadLine());
    if (precio < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        throw new Exception("El precio del producto no puede ser negativo.");
        Console.ResetColor();
    }
    precios[i] = precio;

    Console.WriteLine("Ingrese la cantidad del producto:");
    int cantidad = Convert.ToInt32(Console.ReadLine());
    if (cantidad < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        throw new Exception("La cantidad del producto no puede ser negativa.");
        Console.ResetColor();
    }
    cantidades[i] = cantidad;

    totalProductos++;
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

