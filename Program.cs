// See https://aka.ms/new-console-template for more information
Empleado empl=new Empleado("nora");
empl.cargaTareas();
empl.mostrarTareasPendientes();
Console.WriteLine($"usted tiene {empl.TareasPendientes.Count() } tareas por realizar");
int cantTareas=empl.TareasPendientes.Count();
do
{
    Console.WriteLine("usted realizo una tarea? (s/n) ");
    string valor=Console.ReadLine();
    if (valor =="s")
    {
        Console.WriteLine("ingrese la tarea realizada");
        int numTarea=Convert.ToInt32(Console.ReadLine());
        empl.completarTareas(numTarea);
        cantTareas-=1;
    }
    if (empl.TareasPendientes.Count!=0)
    {
        empl.mostrarTareasPendientes();        
    }
    if (empl.TareasRealizadas.Count!=0)
    {
        empl.mostrarTareasRealizadas();
    }
} while (cantTareas!=0);
