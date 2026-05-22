//tarea 4
string[] nombres= new string[10];
double[] precios = new double[10];
int[] cantidades = new int[10];

int totalProductos=0;

case 4:

                    if (totalProductos == 0)
                    {
                        Console.WriteLine("No hay productos.");
                        break;
                    }

                    int mayor = cantidades[0];
                    int posicion = 0;

                    for (int i = 1; i < totalProductos; i++)
                    {
                        if (cantidades[i] > mayor)
                        {
                            mayor = cantidades[i];
                            posicion = i;
                        }
                    }
Console.WriteLine("Producto más vendido: " + nombres[posicion]);
                    Console.WriteLine("Cantidad vendida: " + mayor);

                    break;

                case 5:

                    double suma = 0;

                    for (int i = 0; i < totalProductos; i++)
                    {
                        suma += precios[i] * cantidades[i];
                    }

                    double promedio = suma / totalProductos;

                    Console.WriteLine("Promedio de ventas: " + promedio);

                    break;

                case 6:

                         salir = true;
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:

                    Console.WriteLine("la opción escogida es inválida.");
                    break;
                    
    
                
            
