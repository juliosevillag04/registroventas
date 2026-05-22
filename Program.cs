string[] nombres = new string[10];
double[] precios = new double[10];
int[] cantidades = new int[10];

case 1:
            if (contador >= 10)
            {
                Console.WriteLine("Limite alcanzado.");
                break;
            }

            Console.WriteLine("\n--- Registrar Producto ---");

            string nombre;
            do
            {
                Console.Write("Nombre del producto: ");
                nombre = Console.ReadLine();
                if (nombre.Trim() == "")
                {
                    Console.WriteLine("El nombre no puede estar vacío.");
                }
            } while (nombre.Trim() == "");
            nombres[contador] = nombre;
            double precio;
            do
            {
                Console.Write("Precio: ");
                precio = double.Parse(Console.ReadLine());
                if (precio <= 0)
                {
                    Console.WriteLine("El precio debe ser mayor a 0.");
                }
            } while (precio <= 0);
            precios[contador] = precio;

            int cantidad;
            do
            {
                Console.Write("Cantidad vendida: ");
                cantidad = int.Parse(Console.ReadLine());
                if (cantidad < 0)
                {
                    Console.WriteLine("La cantidad no puede ser negativa.");
                }
            } while (cantidad < 0);
            cantidades[contador] = cantidad;

            contador++;

            Console.WriteLine("Producto registrado exitosamente.");
            break;

            case 2:
            if (contador == 0)
            {
                Console.WriteLine("No hay productos registrados.");
            }
            else
            {
                Console.WriteLine("\n===== PRODUCTOS =====");
                Console.WriteLine("{0,-15} {1,10} {2,10}", "Producto", "Precio", "Cantidad");
                Console.WriteLine(new string('-', 40));

                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine("{0,-15} ${1,9:F2} {2,10}",
                        nombres[i],
                        precios[i],
                        cantidades[i]);
                }
            }
            break;

        case 3:
            if (contador == 0)
            {
                Console.WriteLine("No hay productos registrados.");
            }
            else
            {
                double total = 0;

                for (int i = 0; i < contador; i++)
                {
                    total += precios[i] * cantidades[i];
                }

                Console.WriteLine("\n===== TOTAL VENDIDO =====");
                Console.WriteLine("Total acumulado: $" + total.ToString("F2"));
            }
            break;

        case 4:
            if (contador == 0)
            {
                Console.WriteLine("No hay productos registrados.");
            }
            else
            {
                int mayor = cantidades[0];
                int posicion = 0;

                for (int i = 1; i < contador; i++)
                {
                    if (cantidades[i] > mayor)
                    {
                        mayor = cantidades[i];
                        posicion = i;
                    }
                }

                Console.WriteLine("\n===== PRODUCTO MÁS VENDIDO =====");
                Console.WriteLine("Nombre: " + nombres[posicion]);
                Console.WriteLine("Cantidad vendida: " + mayor);
            }
            break;

        case 5:
            if (contador == 0)
            {
                Console.WriteLine("No hay productos registrados.");
            }
            else
            {
                double suma = 0;

                for (int i = 0; i < contador; i++)
                {
                    suma += precios[i] * cantidades[i];
                }

                double promedio = suma / contador;

                Console.WriteLine("\n===== PROMEDIO DE VENTAS =====");
                Console.WriteLine("Total vendido: $" + suma.ToString("F2"));
                Console.WriteLine("Cantidad de productos: " + contador);
                Console.WriteLine("Promedio: $" + promedio.ToString("F2"));
            }
            break;

        case 6:
            salir = true;
            Console.WriteLine("¡Gracias por usar el programa!");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
}



