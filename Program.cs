using EJERCICIO_TRABAJO_DE_PROG.___GRUPO_5;
string opcion;
List<Desayuno> desayunos = new List<Desayuno>();

void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("Menú de Desayunos:\n");
    Console.WriteLine("a) Crear desayuno\n");
    Console.WriteLine("b) Listar desayunos\n");
    Console.WriteLine("c) Eliminar desayuno\n");
    Console.WriteLine("d) Salir\n");
    Console.Write("Selecciona una opción: \n");
}
bool continuarPrograma = true;
while (continuarPrograma)
{
    MostrarMenu();
    opcion = Console.ReadLine().ToLower();

    switch (opcion)
    {
        case "a":
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Creación de Desayuno\n");
                Console.Write("Ingrese el nombre del desayuno: \n");
                string desa = Console.ReadLine();
                Console.Write("\nIngrese el precio del desayuno: \n");
                string precio = Console.ReadLine();
                Console.Write("\nIngrese los días que está disponible el desayuno: \n");
                string dias = Console.ReadLine();

                Desayuno desayuno = new Desayuno
                {
                    Nombre = desa,
                    Precio = precio,
                    Dias = dias
                };
                desayunos.Add(desayuno);

                Console.WriteLine("\nDesayuno agregado exitosamente.\n");
                Console.Write("¿Deseas seguir agregando desayunos? (s/n): ");
                continuar = Console.ReadKey().KeyChar.ToString().ToLower() == "s";
            }
            break;