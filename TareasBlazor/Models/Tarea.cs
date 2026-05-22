namespace TareasBlazor.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public DateTime FechaVencimiento { get; set; }
        public bool Completada { get; set; }
    }
}