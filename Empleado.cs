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
    public Tareas Buscador(){
        Tareas tareaBuscada=new Tareas();
        Console.WriteLine("ingrese la descripcion de la tarea que desea buscar");
        string _descripcion=Console.ReadLine();


        foreach (Tareas item in TareasPendientes)
        {
            if (_descripcion==item.Descripcion)
            {
                tareaBuscada=item;
                Console.WriteLine("la tarea fue encontrada !!: ");
                mostrarTarea(tareaBuscada);
            }
            else
            {
                Console.WriteLine("la tarea no fue encontrada");
                tareaBuscada.IDtarea=0;
                 tareaBuscada.Descripcion="no existe tarea";
                tareaBuscada.Duracion=0;

                mostrarTarea(tareaBuscada);


                return tareaBuscada;
            }
        }

        return tareaBuscada;
    }
    public void mostrarTarea(Tareas tarea){
        Console.WriteLine($"IdTarea {tarea.IDtarea} ");
        Console.WriteLine($"Descripcion {tarea.Descripcion} ");
        Console.WriteLine($"Duracion {tarea.Duracion} ");
        Console.WriteLine("");
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
    public void sumarioDeUnEmpleado(){
        int sumario=0;
        foreach (var item in TareasRealizadas)
        {
            sumario=sumario+item.Duracion;
        }
        if (sumario==0)
        {
            Console.WriteLine($"el/la empleado/a {Nombre} no trabajo ");
            
        }
        else
        {
            Console.WriteLine($"el/la empleado/a {Nombre} va trabajo {sumario} hs");
        }

    }

    public void realizarTareas(){
        int cantTareas=TareasPendientes.Count();
        do
        {
            Console.WriteLine("usted quiere realizar una tarea? (s/n) ");
            string valor=Console.ReadLine();
            if (valor =="s")
            {
                Console.WriteLine("ingrese la tarea realizada");
                int numTarea=Convert.ToInt32(Console.ReadLine());
                completarTareas(numTarea);
                cantTareas-=1;
            }
            if (TareasPendientes.Count!=0)
            {
                mostrarTareasPendientes();        
            }
            if (TareasRealizadas.Count!=0)
            {
                mostrarTareasRealizadas();
            }
        } while (cantTareas!=0);

    }


}