class Empleado
{
    private List<Tareas>? tareasPendientes =new List<Tareas>();
    private List<Tareas>? tareasRealizadas=new List<Tareas>();
    private string? nombre;

    public string? Nombre { get => nombre; set => nombre = value; }
    internal List<Tareas>? TareasPendientes { get => tareasPendientes; set => tareasPendientes = value; }
    internal List<Tareas>? TareasRealizadas { get => tareasRealizadas; set => tareasRealizadas = value; }

    public Empleado(string _nombre)
    {
        
        Nombre=_nombre;        
    }
    public Tareas Buscador(string _descripcion){
        Tareas t=new Tareas();

        /*foreach (Tareas item in TareasPendientes)
        {
            if (_descripcion==item.Descripcio)
            {
                return item;
            }
        }*/
        return t;
    }

    public void cargaTareas(){
        List<Tareas> listaTareas=new List<Tareas>();
        Random rand=new Random();
        int nTareas= rand.Next(1,4);
        string? descripcion ;
        Console.WriteLine($"el empleado tiene {nTareas} tareas");
        for (int i = 0; i < nTareas; i++)
        {
            Console.WriteLine($"ingrese la descripcion de la tarea {i+1}");
           descripcion= Console.ReadLine();
            Tareas t=new Tareas(i,descripcion,rand.Next(1,11));           
            
            listaTareas.Add(t);
        }
        TareasPendientes=listaTareas;
        Console.WriteLine("se cargo la lista");
        //cargando con elementos la lista de TareasRealizadas
        for (int i = 0; i < TareasPendientes.Count(); i++)
        {
            Tareas tareaR=new Tareas();
            TareasRealizadas.Add(tareaR);
        }


    }

    public void mostrarTareasPendientes(){
         Console.WriteLine("---- Tareas Pendientes---- ");
        foreach (Tareas item in TareasPendientes)
        {
            Console.WriteLine($"IdTarea {item.IDtarea} ");
            Console.WriteLine($"Descripcion {item.Descripcion} ");
            Console.WriteLine($"Duracion {item.Duracion} ");
             Console.WriteLine("");
        }
    }
    public void mostrarTareasRealizadas(){
         Console.WriteLine("---- Tareas Ralizadas ---- ");
        foreach (Tareas item in TareasRealizadas)
        {
            Console.WriteLine($"IdTarea {item.IDtarea} ");
            Console.WriteLine($"Descripcion {item.Descripcion} ");
            Console.WriteLine($"Duracion {item.Duracion} ");
             Console.WriteLine("");
        }
        Console.WriteLine("");
    }
    
    public void completarTareas(int numTareaCompletada)
    {
        TareasRealizadas[numTareaCompletada-1]=TareasPendientes[numTareaCompletada-1];
        TareasPendientes.RemoveAt(numTareaCompletada-1);

    }


}