using System;
class program
{
    // Cantidad máxima de documentos
    const int MAX_DOCUMENTOS = 100;

    // Datos de los documentos
    static string[] codigos = new string[MAX_DOCUMENTOS];
    static string[] nombresProveedores = new string[MAX_DOCUMENTOS];
    static string[] rucs = new string[MAX_DOCUMENTOS];
    static string[] tiposComprobantes = new string[MAX_DOCUMENTOS];
    static string[] numerosComprobantes = new string[MAX_DOCUMENTOS];
    static string[] fechas = new string[MAX_DOCUMENTOS];
    static string[] productos = new string[MAX_DOCUMENTOS];
    static int[] cantidades = new int[MAX_DOCUMENTOS];
    static double[] preciosUnitarios = new double[MAX_DOCUMENTOS];
    static double[] montosTotales = new double[MAX_DOCUMENTOS];
    static string[] estados = new string[MAX_DOCUMENTOS];

    // Indica cuántos documentos se han registrado
    static int cantidadDocumentos = 0;

    static void Main()

    {
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("=================================================");
            Console.WriteLine("       SISTEMA DE GESTIÓN DOCUMENTAL");
            Console.WriteLine("     INVERSIONES CÓRDOBA PINTADO IRL");
            Console.WriteLine("       DOCUMENTOS DE PROVEEDORES");
            Console.WriteLine("=================================================");
            Console.WriteLine("1. Registrar documento");
            Console.WriteLine("2. Validar documento");
            Console.WriteLine("3. Buscar documento");
            Console.WriteLine("4. Ordenar documentos");
            Console.WriteLine("5. Mostrar documentos almacenados");
            Console.WriteLine("6. Salir");
            Console.WriteLine("===========================================");
            Console.Write("Seleccione una opción: ");

            // Comprueba que se escriba un número
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Write("Entrada incorrecta. Ingrese un número: ");
            }

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    RegistrarDocumento();
                    break;

                case 2:
                    Console.WriteLine("Ha seleccionado: Validar documento.");
                    break;

                case 3:
                    Console.WriteLine("Ha seleccionado: Buscar documento.");
                    break;

                case 4:
                    Console.WriteLine("Ha seleccionado: Ordenar documentos.");
                    break;

                case 5:
                    Console.WriteLine(
                        "Ha seleccionado: Mostrar documentos almacenados.");
                    break;

                case 6:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine(
                        "Opción incorrecta. Seleccione una opción del 1 al 6.");
                    break;
            }

            if (opcion != 6)
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para regresar al menú.");
                Console.ReadKey();
            }

        } while (opcion != 6);
    }
    static void RegistrarDocumento()
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("       REGISTRO DE NUEVO DOCUMENTO");
        Console.WriteLine("===========================================");

        // Comprobar si todavía existe espacio
        if (cantidadDocumentos >= MAX_DOCUMENTOS)
        {
            Console.WriteLine("No hay espacio para registrar más documentos.");
            return;
        }

        // Posición donde se guardará el documento
        int posicion = cantidadDocumentos;

        // Crear un código automático
        codigos[posicion] = $"DOC-{cantidadDocumentos + 1:000}";

        Console.Write("1. Nombre del proveedor: ");
        nombresProveedores[posicion] = Console.ReadLine() ?? "";

        Console.Write("2. RUC del proveedor: ");
        rucs[posicion] = Console.ReadLine() ?? "";

        Console.Write("3. Tipo de comprobante: ");
        tiposComprobantes[posicion] = Console.ReadLine() ?? "";

        Console.Write("4. Número del comprobante: ");
        numerosComprobantes[posicion] = Console.ReadLine() ?? "";

        Console.Write("5. Fecha del comprobante: ");
        fechas[posicion] = Console.ReadLine() ?? "";

        Console.Write("6. Producto adquirido: ");
        productos[posicion] = Console.ReadLine() ?? "";

        Console.Write("7. Cantidad: ");

        while (!int.TryParse(Console.ReadLine(), out cantidades[posicion]) ||
               cantidades[posicion] <= 0)
        {
            Console.Write("Ingrese una cantidad mayor que cero: ");
        }

        Console.Write("8. Precio por unidad: ");

        while (!double.TryParse(Console.ReadLine(), out preciosUnitarios[posicion]) ||
               preciosUnitarios[posicion] <= 0)
        {
            Console.Write("Ingrese un precio mayor que cero: ");
        }

        // Calcular el monto total
        montosTotales[posicion] =
            cantidades[posicion] * preciosUnitarios[posicion];

        // Estado inicial del documento
        estados[posicion] = "Recibido";

        // Aumentar la cantidad de documentos registrados
        cantidadDocumentos++;

        Console.WriteLine();
        Console.WriteLine("Documento registrado correctamente.");
        Console.WriteLine($"Código asignado: {codigos[posicion]}");
        Console.WriteLine($"Monto total: S/ {montosTotales[posicion]:0.00}");
        Console.WriteLine($"Estado: {estados[posicion]}");
    }
}