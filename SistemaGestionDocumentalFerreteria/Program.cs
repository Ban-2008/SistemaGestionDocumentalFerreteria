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
                    Console.WriteLine("Ha seleccionado: Registrar documento.");
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
}