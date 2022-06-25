class Tareas
{
    private int iDtarea;
    private string? descripcion;
    private int duracion;//1-10

    public int IDtarea { get => iDtarea; set => iDtarea = value; }
    public string? Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    
    public Tareas(){}

    public Tareas(int i,string? _descripcion,int _duracion){
        IDtarea=i;

        descripcion=_descripcion;
        duracion=_duracion;
    }
    
}