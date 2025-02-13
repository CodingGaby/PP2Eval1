namespace PP2Eval1;
using System.Collections;

public class Proyecto : GestionTareas
{
    //Clase Proyecto: Esta clase implementará la interfaz GestionTareas y mantendrá una lista de tareas. Tendrá los siguientes métodos:

    public ArrayList tareas;
    
        //cambiarEstadoTarea para actualizar el estado de una tarea específica.

        //Mostrar los datos registrados y almacenados

        //Agregar una tarea más con insert
    public Proyecto(ArrayList tareas) 
    { 
        this.tareas = tareas;
    }

    public void agregarTarea(Tarea tarea)
    {
        tareas.Add(tarea);
    }

    public void cambiarEstadoTarea(int idTarea, string nuevoEstado)
    {
        foreach (Tarea tarea in tareas)
        {
            if (tarea.idTarea == idTarea)
            {
                tarea.estado = nuevoEstado;
            }
        }
    }

    public void mostrarEstado()
    {
        foreach (Tarea tarea in tareas)
        {
            Console.WriteLine($"El estado de la tarea {tarea.idTarea} es: {tarea.estado}");
        }
    }
    public void mostrarTareas()
    {
        foreach (Tarea tarea in tareas)
        {
            Console.WriteLine($"Tarea {tarea.idTarea} es: {tarea.descripcion}");
        }
    }
}