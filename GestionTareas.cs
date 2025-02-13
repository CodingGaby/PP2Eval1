namespace PP2Eval1;

public interface GestionTareas
{
    //Interfaz GestionTareas: La interfaz tendrá los siguientes métodos:
    
    //Agrega una tarea al proyecto
    void agregarTarea(Tarea tarea);
    
    //Cambia el estado de una tarea específica (por ejemplo, "pendiente", "en progreso", "terminada").
    void cambiarEstadoTarea(int idTarea, String nuevoEstado); 

    //Muestra el estado de todas las tareas del proyecto.
    void mostrarEstado();
}