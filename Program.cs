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