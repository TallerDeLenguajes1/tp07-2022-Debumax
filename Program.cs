// See https://aka.ms/new-console-template for more information
Empleado empl=new Empleado("nora");
empl.cargaTareas();
empl.mostrarTareasPendientes();
Console.WriteLine($"usted tiene {empl.TareasPendientes.Count() } tareas por realizar");
//empl.realizarTareas();
empl.sumarioDeUnEmpleado();
empl.Buscador();