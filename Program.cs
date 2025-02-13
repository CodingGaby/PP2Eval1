using PP2Eval1;
using System.Collections;

ArrayList tareasList = new ArrayList();

Proyecto proyecto1 = new Proyecto(tareasList);
string opc = "";

while (opc != "5")
{
    Console.WriteLine("1.Agregar tarea 2.Cambiar estado de tarea 3.Mostrar estado de tareas 4.Mostrar tareas 5.Salir");
    opc = Console.ReadLine();
    
    switch (opc)
    {
        case "1":
            Console.WriteLine("Describe la tarea: ");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Quién es el responsable: ");
            string resp = Console.ReadLine();
            
            //Agregando tarea
            proyecto1.agregarTarea(new Tarea(proyecto1.tareas.Count, descripcion, resp));
            Console.WriteLine("Agregando una tarea al proyecto");
            proyecto1.mostrarTareas();  
            break;
        case "2":
            string estado = "";
            Console.WriteLine("Cual es el ID de la tarea: ");
            int idTarea = Int32.Parse(Console.ReadLine());

            Console.WriteLine("1.Pendiente 2.En progreso 3.Terminada");
            string select = Console.ReadLine();
            if (select == "1") estado = "Pendiente";
            if (select == "2") estado = "En progreso";
            if (select == "3") estado = "Terminada";
            
            Console.WriteLine("Cambiando el estado de una tarea");
            proyecto1.cambiarEstadoTarea(idTarea,estado);
            proyecto1.mostrarEstado();
            break;
        case "3":
            Console.WriteLine("Mostrando el estado de las tareas del proyecto");
            proyecto1.mostrarEstado();
            break;
        case "4":
            Console.WriteLine("Mostrando las tareas del proyecto");
            proyecto1.mostrarTareas();
            break;
        default: 
            Console.WriteLine("Opción no encontrada...");
            break;
    }
    
}