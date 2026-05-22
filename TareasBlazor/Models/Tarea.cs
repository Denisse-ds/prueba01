namespace TareasBlazor.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public DateTime FechaVencimiento { get; set; }
        public bool Completada { get; set; } //MODIFICADO: Cambiamos el tipo de dato a bool para representar si la tarea está completada o no
    }
}