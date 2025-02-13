namespace PP2Eval1;

public class Tarea
{
    //Clase Tarea: Esta clase representará una tarea dentro del proyecto. Tendrá los siguientes atributos:

    //Identificador de la tarea
    public int idTarea { get; set; }

    //Descripción de la tarea
    public String descripcion {get; set; }

    //estado de la tarea, como "pendiente", "en progreso", "terminada"
    public String estado { get; set; }

    //persona encargada de realizar la tarea
    public String responsable { get; set; }

    public Tarea(int idTarea, string descripcion, string responsable)
    {
        this.idTarea = idTarea;
        this.descripcion = descripcion;
        estado = "pendiente";
        this.responsable = responsable;
    }
}